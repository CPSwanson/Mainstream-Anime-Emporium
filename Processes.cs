using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace Mainstream_Anime_Emporium
{
    public class Processes
    {
        private static frmLogin login;
        private static List<_item> _cart = new List<_item>();
        private static bool _manager = false;
        private static int _id;
        private static double _subTotal = 0.00;
        private static double _tax = 0.00;
        private static double _total = 0.00;
        private static DataTable _dtProducts = new DataTable();
        private static List<_image> _Images = new List<_image>();
        public struct _image
        {
            private int id;
            private Image image;

            public int ID
            {
                get { return id; }
                set { id = value; }
            }

            public Image Image
            {
                get { return image; }
                set { image = value; }
            }
        }
        public struct _item
        {
            private int id;
            private int quantity;

            public int ID
            {
                get { return id; }
                set { id = value; }
            }

            public int Quantity
            {
                get { return quantity; }
                set { quantity = value; }
            }
        }

        #region Public properties
        public static DataTable DTProducts
        {
            set { _dtProducts = value; }
            get { return _dtProducts; }
        }

        public static List<_item> Cart
        {
            get { return _cart; }
        }

        public static List<_image> Images
        {
            get { return _Images; }
        }

        public static frmLogin Login
        {
            set { login = value; }
            get { return login; }
        }

        public static bool Manager
        {
            get { return _manager; }
        }

        public static int ID
        {
            get { return _id; }
        }

        public static double Sub
        {
            get { return _subTotal; }
        }

        public static double Tax
        {
            get { return _tax; }
        }

        public static double Total
        {
            get { return _total; }
        }
        #endregion

        //Adds item to cart and updates totals and tax accordingly
        public void addToCart(int ID, int quantity)
        {

            bool newItem = true;

            //Looks for existing instance of item in cart, if so, the quantity will be updated
            for (int i = 0; i < Cart.Count; i++)
            {
                if (ID == Cart[i].ID)
                {
                    int tQ = Cart[i].Quantity + quantity;
                    _item replace = new _item();
                    replace.ID = ID;
                    replace.Quantity = tQ;
                    Cart[i] = replace;
                    newItem = false;
                    break;
                }
            }

            //If no existing instance is found, a new one will be generated
            if (newItem)
            {
                _item item = new _item();
                item.ID = ID;
                item.Quantity = quantity;
                Cart.Add(item);
            }

            foreach (DataRow item in DTProducts.Rows)
            {
                if (int.Parse(item[0].ToString()) == ID)
                {
                    double price = double.Parse(item[2].ToString());
                    double discount = double.Parse(item[2].ToString()) * (double.Parse(item[3].ToString()) / 100);
                    _subTotal += ((price - discount) * quantity);
                    _tax = Math.Round(Sub * 0.0825, 2);
                    _total = Sub + Tax + 9.99;
                    break;
                }
            }

        }

        //Removes item from cart and updates totals and tax accordingly
        public void removeFromCart(int ID)
        {
            foreach (_item item in Cart)
            {
                if (ID == item.ID)
                {
                    foreach (DataRow row in _dtProducts.Rows)
                    {
                        if (int.Parse(row[0].ToString()) == ID)
                        {
                            double price = double.Parse(row[2].ToString());
                            double discount = double.Parse(row[2].ToString()) * (double.Parse(row[3].ToString()) / 100);
                            _subTotal -= ((price - discount) * item.Quantity);
                            _tax = Math.Round(Sub * 0.0825, 2);
                            _total = Sub + Tax + 9.99;
                            break;
                        }
                    }
                    Cart.Remove(item);
                    break;
                }
            }
        }

        //Clears the cart on log out or purchase
        public void clearCart()
        {
            Cart.Clear();
            _subTotal = 0.00;
            _tax = 0.00;
            _total = 0.00;
        }

        //Get's the approrpiate image for the product
        public Image getImage(int id)
        {
            foreach (_image im in Images)
            {
                if (im.ID == id)
                {
                    return im.Image;
                }
            }

            return null;
        }

        #region Db functions
        //Pulls in all products in database
        public bool loadProducts()
        {
            string connect = "Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787";
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand("Select * From cpswanson.products", con);
            SqlDataAdapter _daProducts = new SqlDataAdapter();

            try
            {
                con.Open();

                _dtProducts.Clear();
                _daProducts.SelectCommand = cmd;
                _daProducts.Fill(DTProducts);

                DataTable _dtImages = new DataTable();
                cmd = new SqlCommand("Select * from cpswanson.productImages", con);
                _daProducts.SelectCommand = cmd;
                _daProducts.Fill(_dtImages);

                foreach (DataRow item in _dtImages.Rows)
                {
                    _image temp = new _image();
                    temp.ID = int.Parse(item[0].ToString());
                    byte[] data = new Byte[0];
                    data = (byte[])(item[1]);
                    MemoryStream mem = new MemoryStream(data);
                    temp.Image = Image.FromStream(mem);
                    _Images.Add(temp);
                }

                con.Close();
                return true;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
                return false;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message.ToString());
                return false;
            }
        }

        //Pulls customer info from database
        public DataTable getCustInfo()
        {
            string connect = "Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787";
            SqlConnection con = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand($"Select * From cpswanson.customers Where customerID = {ID}", con);
            SqlDataAdapter _daProducts = new SqlDataAdapter();

            try
            {
                DataTable temp = new DataTable();

                _daProducts.SelectCommand = cmd;
                _daProducts.Fill(temp);

                return temp;
            }
            catch
            {
                return null;
            }
        }

        //Grabs user's password and emails it to them
        public string getPassword(string username, string email)
        {
            SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787");
            SqlCommand cmd = new SqlCommand($"Select password From cpswanson.customers Where username = '{username}'", con);

            try
            {
                con.Open();
                string pw = cmd.ExecuteScalar().ToString();

                if (pw == "")
                {
                    cmd = new SqlCommand($"Select password From cpswanson.employees Where username = '{username}'", con);
                    pw = cmd.ExecuteScalar().ToString();
                    if (pw == "")
                        return "Username not found.";
                }

                MailMessage mail = new MailMessage();
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                MailAddress to = new MailAddress(email);

                mail.From = new MailAddress("cpswansontest@gmail.com");
                mail.To.Add(to);
                mail.Subject = "Password Recovery";
                mail.Body = $"Your password is {pw}.";

                client.Port = 587;
                client.Credentials = new NetworkCredential("cpswansontest","Cswanson1997!");
                client.EnableSsl = true;
                client.Send(mail);

                con.Close();
                return "Check email.";
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        //Pulls employee info from database
        public DataTable getEmpInfo()
        {
            DataTable temp = new DataTable();

            SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787");
            SqlCommand cmd = new SqlCommand($"Select * From cpswanson.employees", con);

            con.Open();
            SqlDataAdapter _daRead = new SqlDataAdapter();
            _daRead.SelectCommand = cmd;
            _daRead.Fill(temp);
            con.Close();

            return temp;
        }

        public DataTable getEmpInfo(int id)
        {
            DataTable temp = new DataTable();

            SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787");
            SqlCommand cmd = new SqlCommand($"Select * From cpswanson.employees Where empID = {_id}", con);

            con.Open();
            SqlDataAdapter _daRead = new SqlDataAdapter();
            _daRead.SelectCommand = cmd;
            _daRead.Fill(temp);
            con.Close();

            return temp;
        }

        //Checks database for customer based on provided credentials
        public bool custLogIn(string un, string pw)
        {
            string connectS = "Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787";
            SqlConnection con = new SqlConnection(connectS);
            SqlCommand com = new SqlCommand($"Select customerID From cpswanson.customers Where username Like '{un}' And password Like '{pw}'", con);

            try
            {
                con.Open();
                _id = int.Parse(com.ExecuteScalar().ToString());
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Checks database for an employee based on provided credentials
        public bool empLogIn(string un, string pw)
        {
            string connectS = "Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787";
            SqlConnection con = new SqlConnection(connectS);
            SqlCommand com = new SqlCommand($"Select empID From cpswanson.employees Where username Like '{un}' And password Like '{pw}'", con);

            try
            {
                con.Open();
                _id = int.Parse(com.ExecuteScalar().ToString());

                com = new SqlCommand($"Select manager_id From cpswanson.employees Where empid = {_id}",con);
                string mID = com.ExecuteScalar().ToString();
                if(mID == "")
                {
                    _manager = true;
                }
                else
                {
                    _manager = false;
                }

                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Inserts new customer into database
        public string newAccount(string un, string pw, string fName, string lName)
        {
            string connectS = "Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787";
            SqlConnection con = new SqlConnection(connectS);

            try
            {
                SqlCommand cmd = new SqlCommand($"Insert Into cpswanson.Customers(username,password,first_name,last_name) Values ('{un}','{pw}','{fName}','{lName}')", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return "Account created.";
            }
            catch (SqlException ex)
            {
                return ex.ToString();
            }
        }

        //Inserts order information into database
        public string newOrder(string address, string city, string state, string zip, string phone, string email)
        {
            string connectS = "Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787";
            SqlConnection con = new SqlConnection(connectS);

            try
            {
                con.Open();

                //Creates record of the order
                SqlCommand com = new SqlCommand($"Insert Into cpswanson.Orders(customerID,orderDate,totalPrice) Values({ID},Convert(date,getdate()),{Total})", con);
                com.ExecuteNonQuery();

                //Updates customer information based on input at checkout
                com = new SqlCommand($"Update cpswanson.customers Set address = '{address}', city = '{city}', state = '{state}', zip = '{zip}', " +
                    $"phone = '{phone}', email = '{email}' Where customerid = {ID}", con);
                com.ExecuteNonQuery();

                //Grabs id of order for later use
                com = new SqlCommand("Select MAX(orderid) From cpswanson.Orders", con);
                int oID = int.Parse(com.ExecuteScalar().ToString());

                //Creates a record of the contents of the order
                foreach (_item item in Cart)
                {
                    com = new SqlCommand($"Insert Into cpswanson.orderDetails(orderID,productID,numOrdered) Values({oID},{item.ID},{item.Quantity})", con);
                    com.ExecuteNonQuery();
                }

                con.Close();
                clearCart();
                return "Order processed.";
            }
            catch (Exception ex)
            {
                return "Order failed to process.\n" + ex.ToString();
            }
        }

        //Updates employee information
        public string updateEmp(string un, string pw, string fn, string ln, string phone, string email)
        {
            SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787");
            SqlCommand cmd = new SqlCommand($"Update cpswanson.employees Set username = '{un}', password = '{pw}', first_name= '{fn}'," +
                $"last_name= '{ln}', phone= '{phone}', email= '{email}' Where empID = {_id}", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                return "Your updated information has been saved.";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

        }

        //Adds product to database
        public string addProduct(string desc, double price, int quan, Image image)
        {
            SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787");
            SqlCommand cmd = new SqlCommand("Insert Into cpswanson.products(description,price,discount,supplierid,quantity)" +
                $"Values('{desc}',{price},0.00,4000,{quan})", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                int id;
                cmd = new SqlCommand("Select Max(productid) From cpswanson.products", con);
                id = int.Parse(cmd.ExecuteScalar().ToString());

                MemoryStream stream = new MemoryStream();
                image.Save(stream, ImageFormat.Png);
                byte[] data = stream.ToArray();
                cmd = new SqlCommand($"Insert Into cpswanson.productImages(productID,pImage) Values({id},@image)", con);
                SqlParameter param = cmd.Parameters.AddWithValue("@image", data);
                param.DbType = DbType.Binary;
                cmd.ExecuteNonQuery();

                con.Close();

                invoice(id, quan, (quan * price));
                loadProducts();

                return "Product has been added.";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Updates inventory of existing product
        public string updateInv(int id, string desc, double price, double discount, int quan, Image image)
        {
            SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787");
            SqlCommand cmd = new SqlCommand($"Update cpswanson.products Set description = '{desc}'," +
                $"price = {price}, discount = {discount}," +
                $"quantity = (quantity + {quan}) Where productID = {id}", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();

                double cost;
                cmd = new SqlCommand($"Select price From cpswanson.products Where productid = {id}", con);
                cost = double.Parse(cmd.ExecuteScalar().ToString()) * quan;

                MemoryStream stream = new MemoryStream();
                image.Save(stream, ImageFormat.Png);
                byte[] data = stream.ToArray();
                cmd = new SqlCommand($"Insert Into cpswanson.productImages(productID,pImage) Values({id},@image)", con);
                SqlParameter param = cmd.Parameters.AddWithValue("@image", data);
                param.DbType = DbType.Binary;
                cmd.ExecuteNonQuery();

                con.Close();

                if(quan > 0)
                {
                    invoice(id, quan, cost);
                }
                
                loadProducts();

                return "Inventory updated.";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Removes product from inventory
        public string removeProduct(int id)
        {
            SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787");
            SqlCommand cmd = new SqlCommand($"Delete From cpswanson.products Where productID = {id}", con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                loadProducts();

                return "Item removed.";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        //Log invoices for inventory purchased by manager
        private void invoice(int id, int quantity, double cost)
        {
            SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787");
            SqlCommand cmd = new SqlCommand("Insert Into cpswanson.invoices(productid,date,quantity,cost)" +
                $"Values({id},Convert(date,getdate()),{quantity},{cost})", con);
            
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Sends requests made by employees to database
        public void sendRequest(string request)
        {
            SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787");
            SqlCommand cmd = new SqlCommand($"Insert Into cpswanson.schRequests(empID,request) Values({ID},'{request}')",con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Gets schedule of selected employee
        public DataTable[] getSchedule(int id)
        {
            DataTable[] temp = new DataTable[2];
            temp[0] = new DataTable();
            temp[1] = new DataTable();

            SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787");
            SqlCommand cmd = new SqlCommand($"Select * From cpswanson.empSchedule Where employeeID = {id}", con);

            SqlDataAdapter _daAdapter = new SqlDataAdapter();
            _daAdapter.SelectCommand = cmd;

            con.Open();
            _daAdapter.Fill(temp[0]);

            cmd = new SqlCommand($"Select * From cpswanson.schRequests Where empID = {id}", con);
            _daAdapter.SelectCommand = cmd;
            _daAdapter.Fill(temp[1]);
            con.Close();

            return temp;
        }

        //Updates employee's schedule
        public void upSchedule(int id, string[] days, int vaca, int sL)
        {
            SqlConnection con = new SqlConnection("Data Source=cstnt.tstc.edu;Initial Catalog=ITSW1307;Persist Security Info=True;User ID=cpswanson;Password=1498787");
            SqlCommand cmd = new SqlCommand($"Update cpswanson.empSchedule Set Mon = '{days[0]}', Tues = '{days[1]}', Wed = '{days[2]}'," +
                $"Thur = '{days[3]}', Fri = '{days[4]}', Sat = '{days[5]}', Sun = '{days[6]}'," +
                $"Sick_days_left = {sL}, Vacation_days_left = {vaca} " +
                $"Where employeeID = {id}", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        #endregion
    }
}
