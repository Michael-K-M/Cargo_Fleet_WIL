using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WILL_Project
{
    class DB_Connection
    {
        public static SqlConnection con = null;

        public DB_Connection()
        {
           
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            string newpath = path.Remove(path.Length - 9, 9) + "DataBase.mdf";
            string fullPath = newpath.Remove(0, 6);

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + fullPath + ";Integrated Security=True");
        }
        
        // Selecting a Trip -----------------
        public SqlDataReader SelectTrip() // may need to delete
        {
            //Added a comment
            String sql = "select * from Trip where Status = 'Stationary'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;
            
        }

        public SqlDataReader SelectAssinedTrip(String Driver) // may need to delete
        {

            String sql = "select T.R_City from Trip T, History H, Login L where T.Status = 'waiting' and T.TripID = H.TripID and L.EmpID = H.DriverID and L.EmpID = '" + Driver+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;

        }

        public SqlDataReader RequestTrip()
        {

            String sql = "select * from Trip where Status = 'Request'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;
        }

        public void ChangeRequest(String TripID) 
        {
           
            String sql = "update Trip set Status = 'Stationary' where Status='Request' and TripID = '" + TripID + "'";

            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }
        public void DeclineTripRequest(String TripID)
        {

            String sql = "update Trip set Status = 'Decline' where Status='Request' and TripID = '" + TripID + "'";

            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader DisplayVType()
        {
            
            String sql = "select * from Vehical where Status = 'Stationary'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;
        }

        public SqlDataReader ChooseDriver()
        {
            String sql = "select * from Login where PossitionRole = 'Driver'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;
        }

        public void fillDB(string UserID, string VehicalID, string TripID, String date)
        {
         
            string help = "INSERT INTO History ([DriverID], [VehicalID], [TripID],[Start_Date], [Status]) VALUES('" + UserID + "', ' " + VehicalID + "', '" + TripID + "', '" + date + "', '" + " Active " + "'); ";
            SqlCommand cmd = new SqlCommand(help, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }
        //----------------------------------------------------------------------------------------------------- this is for driver
        public SqlDataReader DisplayDriverInfo(String DriverID)
        {
            String sql = "select * from History where DriverID = '"+DriverID+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;
        }

        public SqlDataReader StandardService() // may need to delete
        {

            // String sql = "select T.R_City from Trip T, History H, Login L where T.Status = 'waiting' and T.TripID = H.TripID and L.EmpID = H.DriverID and L.EmpID = '" + Driver + "'";
            String sql = "select * from Service where Problem = 'N/A' and Status = 'Pending'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;

        }

        public SqlDataReader IncedintService() // may need to delete
        {

            // String sql = "select T.R_City from Trip T, History H, Login L where T.Status = 'waiting' and T.TripID = H.TripID and L.EmpID = H.DriverID and L.EmpID = '" + Driver + "'";
            String sql = "select * from Service where Status = 'Pending'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;

        }

        public void ChangeStatus(String TripID)
        {
             
            String sql = "update Trip set Status = 'waiting' where Status='Stationary' and TripID = '" + TripID + "'";

            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public SqlCommand UpdateTripEndDate(string EndTrip, string TripID)
        {
            // update History set End_Date = '"+EndTrip+"' from History h, Trip t WHERE h.TripID = t.TripID and t.TripID = '"+TripID+"'
            String query = "update History set End_Date = '" + EndTrip + "' where TripID = '" + TripID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            return cmd;
        }

        public void ChangeTStatus(String TripID)
        {

            String sql = "update Trip set Status = 'Active' where Status='waiting' and TripID = '" + TripID + "'";

            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader SelectTripIndex(String Trip)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = D:\VARSITY\WILLPROG\WILL_PROJECT\WILL_PROJECT\DATABASE.MDF");
            String sql = "select * from Trip where R_Name = '" + Trip + "' ";
            //String sql1 = "UPDATE Trip set Status = @Status", _con;
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;

        }

        public SqlDataReader SelectedService(String Trip)
        {
           
            String sql = "select * from Service where Vehicle_Make = '" + Trip + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;

        }

        public SqlDataReader SelectedIncService(String Trip)
        {

            String sql = "select ServiceID, Vehicle_Make, Vehicle_Model, Number_Plate, Date, Problem, Vehicle_ID from Service where Number_Plate = '" + Trip + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;

        }

        public SqlDataReader SelectedStaService(String Trip)
        {

            String sql = "select ServiceID, Vehicle_Make, Vehicle_Model, Number_Plate, Date, Total_Milage, Vehicle_ID from Service where Vehicle_Make = '" + Trip + "' ";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;

        }

        public void closeConnection()
        {
            con.Close();
        }
        //-COMPLETE  TRIP----------------------------------------------------------------------

        public SqlDataReader Fillcombo(String UserID)
        {
                 //      1               //                                 2                                //                                              3                                                       ///             4
            String sql = "select Tr.[R_Name] from [Vehical] as ve, [Login] as Lo, [Trip] as Tr, [History] as His where Ve.[VehicalID] = His.[VehicalID] and Lo.[EmpID] = His.[DriverID] and Tr.[TripID] = His.[TripID] AND Tr.Status = 'Active' AND DriverID = '" + UserID + "' ";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;
        }

        public void ChangeTripStatus(String tripID)
        {
            string complete = "Complete";

           // SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = D:\VARSITY\WILLPROG\WILL_PROJECT\WILL_PROJECT\DATABASE.MDF");

            //   String sql = "UPDATE Trip(Status) VALUES (@Status)";   Complete   Active

            String sql = "update Trip set Status = 'Complete' where Status = 'Active' and TripID = '" + tripID + "'";

            SqlCommand cmd = new SqlCommand(sql, con);

            con.Open();

            cmd.ExecuteNonQuery();
        }

        //---------VIEW THE TRIPS IN OM_VIEWTRIP--------------------------------------------------------------------------------------------
        public SqlCommand Active()
        {
           // String query = "select Lo.[FirstName] as 'Driver Name', Lo.[LastName] as 'Last Name', Ve.[Vehical_Make], Ve.[Vehical_Model], Ve.[VIN_Number], Tr.[R_StreetAddress], Tr.[R_City], Tr.[Status] from [Vehical] as ve, [Login] as Lo, [Trip] as Tr, [History] as His where Ve.[VehicalID] = His.[VehicalID] and Lo.[EmpID] = His.[DriverID] and Tr.[TripID] = His.[TripID] AND Tr.Status = 'Active'";
            String query = "select Tr.[R_Name] as 'Customer Name', Tr.[R_StreetAddress] as 'Customer Street', Tr.[R_City] as 'Customer City', Lo.[FirstName] as 'Driver Name', Lo.[LastName] as 'Driver Surename', Ve.[Vehical_Make] as 'Vehical Make', Ve.[Vehical_Model] as 'Vehical Model', Ve.[VIN_Number] as 'VIN Number', Tr.[Status] from [Vehical] as ve, [Login] as Lo, [Trip] as Tr, [History] as His where Ve.[VehicalID] = His.[VehicalID] and Lo.[EmpID] = His.[DriverID] and Tr.[TripID] = His.[TripID] AND Tr.Status = 'Active'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }

        public SqlCommand Complete()
        {
            String query = "select Tr.[R_Name] as 'Customer Name', Tr.[R_StreetAddress] as 'Customer Street', Tr.[R_City] as 'Customer City', Lo.[FirstName] as 'Driver Name', Lo.[LastName] as 'Driver Surename', Ve.[Vehical_Make] as 'Vehical Make', Ve.[Vehical_Model] as 'Vehical Model', Ve.[VIN_Number] as 'VIN Number', Tr.[Status] from [Vehical] as ve, [Login] as Lo, [Trip] as Tr, [History] as His where Ve.[VehicalID] = His.[VehicalID] and Lo.[EmpID] = His.[DriverID] and Tr.[TripID] = His.[TripID] AND Tr.Status = 'Complete'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }

        public SqlCommand test()
        {
            String query = "Select * from Login";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }

        public SqlCommand Pending()
        {
            String query = "select [R_Name] as 'Customer Name', [R_StreetAddress] as 'Customer Street', [R_City] as 'Customer City', [R_Postcode] as 'Customer Postcode', [Status] from Trip WHERE Status='waiting'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }
        //-------------Create new Account -----------------------------------------------------------

        public SqlCommand create()
        {
            String query = "INSERT INTO Login (FirstName, LastName, DOB, Address, Username, Password, PossitionRole) VALUES (@FirstName, @LastName, @DOB, @Address, @Username, @Password, @PossitionRole) ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }
        public SqlCommand createCustomer()
        {
            String query = "INSERT INTO Login (FirstName, LastName, DOB, Address, Username, Password) VALUES (@FirstName, @LastName, @DOB, @Address, @Username, @Password) ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }

        public SqlCommand createTrip()
        {

            //  SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = D:\VARSITY\WILLPROG\WILL_PROJECT\WILL_PROJECT\DATABASE.MDF");
            String query = "INSERT INTO Trip (S_Name, S_StreetAddress, S_City, S_Postcode, S_Province, S_Phone, R_Name, R_StreetAddress, R_City, R_Postcode, R_Province, R_Phone, R_Description)" +
            " VALUES (@S_Name, @S_StreetAddress, @S_City, @S_Postcode, @S_Province, @S_Phone, @R_Name, @R_StreetAddress, @R_City, @R_Postcode, @R_Province, @R_Phone, @R_Description)";
            SqlCommand cmd = new SqlCommand(query, con);

        con.Open();
            return cmd;
        }

        public SqlCommand createVehicle()
        {

            //  SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = D:\VARSITY\WILLPROG\WILL_PROJECT\WILL_PROJECT\DATABASE.MDF");
            String query = "INSERT INTO Vehical (Vehical_Make, Vehical_Model, Vehical_Year, VIN_Number, Engine_Size, Number_Plate, Capacity)" +
            " VALUES (@Vehical_Make, @Vehical_Model, @Vehical_Year, @VIN_Number, @Engine_Size, @Number_Plate, @Capacity)";
            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            return cmd;
        }
        public DataTable Login(String Username, String Password)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename = D:\VARSITY\WILLPROG\WILL_PROJECT\WILL_PROJECT\DATABASE.MDF");
            SqlDataAdapter sda = new SqlDataAdapter("Select PossitionRole, empID from Login Where UserName='" + Username + "' and Password='" + Password + "'   ", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            return dt;

            //SqlDataAdapter sda = new SqlDataAdapter("Select PossitionRole, empID from Login Where UserName='" + tb_Username.Text + "' and Password='" + tb_Password.Text + "'   ", con);
        }

        public SqlDataReader FillEmpRole()
        {
            //      1               //                                 2                                //                                              3                                                       ///             4
            //String sql = "select Tr.[R_Name] from [Vehical] as V, [Login] as L, [Trip] as T, [History] as His where Ve.[VehicalID] = His.[VehicalID] and Lo.[EmpID] = His.[DriverID] and Tr.[TripID] = His.[TripID] AND Tr.Status = 'Active' AND DriverID = '" + UserID + "' ";
            String sql = "SELECT distinct L.PossitionRole from Login L";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;
        }

        public SqlDataReader FillEmpName(String Role)
        {
           
            String sql = "SELECT L.FirstName from Login L where L.PossitionRole = '"+Role+"'";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;
        }

        public SqlCommand empRate()
        {
            String query = "INSERT INTO Emp_Rate (Role, Name, StartTime, EndTime, RPH, Date, Wage) VALUES (@Role, @Name, @StartTime, @EndTime, @RPH, @Date, @Wage) ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }

        public SqlCommand FuelCon()
        {
            String query = "INSERT INTO Fuel_Consumption (Number_Plate, L_B_T, L_A_T, PPL) VALUES (@Number_Plate, @L_B_T, @L_A_T, @PPL) ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }
        public SqlDataReader FillNP()
        {
            //      1               //                                 2                                //                                              3                                                       ///             4
            //String sql = "select Tr.[R_Name] from [Vehical] as V, [Login] as L, [Trip] as T, [History] as His where Ve.[VehicalID] = His.[VehicalID] and Lo.[EmpID] = His.[DriverID] and Tr.[TripID] = His.[TripID] AND Tr.Status = 'Active' AND DriverID = '" + UserID + "' ";
            String sql = "SELECT Number_Plate from Vehical";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;
        }
        public SqlCommand IncidentRec()
        {
            String query = "INSERT INTO Trip_Incidents (Location, CauseOf, Driver, VehicleMake, VehicleModel, NumberPlate, OtherParties, Vehicle_ID) VALUES (@Location, @CauseOf, @Driver, @VehicleMake, @VehicleModel, @NumberPlate, @OtherParties, @Vehicle_ID) ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }
        public SqlCommand StatVehicleSta()
        {
            String query = "select V.Vehical_Make, V.Vehical_Model, V.Vehical_Year, V.VIN_Number, V.Engine_Size, V.Number_Plate, V.Capacity, V.Status from Vehical V where V.Status like '%stationary%'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }

        
        public SqlCommand StatVehicleAct()
        {
            String query = "select V.Vehical_Make, V.Vehical_Model, V.Vehical_Year, V.VIN_Number, V.Engine_Size, V.Number_Plate, V.Capacity from Vehical V where V.Status like '%Active%';";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }
        public SqlCommand StatVehicleSer()
        {
            String query = "select V.Vehical_Make, V.Vehical_Model, V.Vehical_Year, V.VIN_Number, V.Engine_Size, V.Number_Plate, V.Capacity from Vehical V where V.Status like 'In_Service';";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }

        public SqlDataReader Select_NP()
        {
            String sql = "SELECT v.Number_Plate, h.VehicalID, h.TripID from Vehical v, History h, Trip t where h.VehicalID = v.VehicalID and h.TripID = t.TripID and t.Status = 'Active'";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;
        }

        public SqlDataReader VID(String NP)
        {
            String sql = "SELECT VehicalID from Vehical where  Number_Plate = '"+NP+"'";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;
        }

        public SqlDataReader TripInc(String NP)
        {
            
            String sql = "select l.FirstName, v.Vehical_Make, Vehical_Model from Login l, Vehical v, History h where l.EmpID = h.DriverID and v.VehicalID = h.VehicalID and v.Number_Plate = '" + NP + "' ";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;
        }

        public SqlCommand createService()
        {
            //Vehicle_Make Vehicle_Model Number_Plate Total_Milage Date Problem  /////////  VehicleID
            String query = "INSERT INTO Service (Vehicle_Make, Vehicle_Model, Number_Plate, Total_Milage, Date, Vehicle_ID) VALUES (@Vehicle_Make, @Vehicle_Model, @Number_Plate, @Total_Milage, @Date, @Vehicle_ID) ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }

        public SqlCommand createIncService()
        {
            //Vehicle_Make Vehicle_Model Number_Plate Total_Milage Date Problem
            String query = "INSERT INTO Service (Vehicle_Make, Vehicle_Model, Number_Plate, Date, Problem, Vehicle_ID) VALUES (@Vehicle_Make, @Vehicle_Model, @Number_Plate, @Date, @Problem, @Vehicle_ID) ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }
        public SqlDataReader incedentDD()
        {
            String sql = "SELECT * from Trip_Incidents where Status = 'Broken'";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;
        }

        public void ChangeIncStatus(String Vehicle_ID)
        {

            String sql = "update Trip_Incidents set Status = 'In-Service' where Status = 'Broken' and Vehicle_ID = '" + Vehicle_ID + "'";

            SqlCommand cmd = new SqlCommand(sql, con);

            con.Open();

            cmd.ExecuteNonQuery();
        }
        public SqlDataReader SelectIncident(String NP)
        {
            String sql = "select * from Trip_Incidents where NumberPlate = '" + NP + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;
        }

        public SqlDataReader DisplayDriverTrip(String name)
        {

            String sql = "select T.TripID, T.R_Name, T.R_StreetAddress, T.R_City, T.R_Postcode, T.R_Province, T.R_Phone, T.R_Description, V.Vehical_Make, H.Start_Date, T.TripID, V.VehicalID from Trip T, History H, Vehical V, Login L where H.TripID = T.TripID and H.DriverID = L.EmpID and T.R_City = '" + name + "'";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;
        }

        public SqlCommand CompleteService()
        {
            String query = "INSERT INTO Complet_Service (ServiceID, Description, Price) VALUES (@ServiceID, @Description, @Price) ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }

        

        public void ChangeService(String TripID)
        {

            String sql = "update Service set Status = 'Complete' where Status='Pending' and ServiceID = '" + TripID + "'";

            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void ChangeV_Status(String V_ID)
        {
            String sql = "update Vehical set Status = 'Active' where Status='Stationary' and VehicalID = '" + V_ID+"' ";

            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public void ChangeV_AfterTrip(String V_ID)
        {
            String sql = "update Vehical set Status = 'Stationary' where VehicalID = '" + V_ID + "' ";

            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }
        public void ChangeV_Incident(String V_ID)
        {
            String sql = "update Vehical set Status = 'In_Service' where VehicalID = '" + V_ID + "' ";

            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }
        public void ChangeV_Fixed(String V_ID)
        {
            String sql = "update Vehical set Status = 'Stationary' where VehicalID = '" + V_ID + "' ";

            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }

        public SqlDataReader DisplayStandard()
        {

            String sql = "select DISTINCT Vehical_Make from Vehical";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;
        }

        public SqlDataReader DisplayStandardNP(String V_Make)
        {

            String sql = "select Number_Plate from Vehical where Vehical_Make = '"+V_Make+"'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;
        }

        public SqlDataReader StandardServiceInfo(String Make, String NP)
        {

            String sql = "select Vehical_Model from  Vehical where Vehical_Make = '"+Make+"' and Number_Plate = '"+NP+"' ";
             SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;

        }
        public SqlCommand updateLogin(string FirstName, string LastName, string DOB, string Address, string Username, string Password, string Role, string UserID)
        { 
            string query = "UPDATE LOGIN SET FirstName = '" + FirstName + "', LastName = '" + LastName + "', DOB = '" + DOB + "', Address = '" + Address + "', Username = '" + Username + "', Password = '" + Password + "', PossitionRole = '" + Role + "' where EmpID = '"+UserID+"' ";
        SqlCommand cmd = new SqlCommand(query, con);
        con.Open();
            return cmd;
        }


        // CRUD
        
        public SqlCommand LoadEmployees()
        {
            String query = "Select * from Login";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }

        public SqlCommand UpdateEmployees(string FirstName, string LastName, string DOB, string Address, string Username, string Password, string Role, string UserID)
        {
            string query = "UPDATE LOGIN SET FirstName = '" + FirstName + "', LastName = '" + LastName + "', DOB = '" + DOB + "', Address = '" + Address + "', Username = '" + Username + "', Password = '" + Password + "', PossitionRole = '" + Role + "' where EmpID = '" + UserID + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }

        public SqlCommand LoadVehicals()
        {
            String query = "Select * from Vehical";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }

        public SqlCommand UpdateVehicals(string V_Make, string V_Model, string V_Year, string V_VIN, string V_Size, string NP, string Cap, string status, string V_ID)
        {
            string query = "UPDATE Vehical SET Vehical_Make = '" + V_Make + "', Vehical_Model = '" + V_Model + "', Vehical_Year = '" + V_Year + "', VIN_Number = '" + V_VIN + "', Engine_Size = '" + V_Size + "', Number_Plate = '" + NP + "', Capacity = '" + Cap + "', Status = '" + status + "' where VehicalID = '" + V_ID + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }

        public SqlCommand LoadService()
        {
            String query = "Select * from Service";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }

        public SqlCommand UpdateService(string make, string model, string NP, string Milage, string Date, string Problem, string status, string ServiceID)
        {
            string query = "UPDATE Service SET Vehicle_Make = '" + make + "', Vehicle_Model = '" + model + "', Number_Plate = '" + NP + "', Total_Milage = '" + Milage + "', Date = '" + Date + "', Problem = '" + Problem + "', Status = '" + status + "' where ServiceID = '" + ServiceID + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }

        public SqlCommand LoadFuelCon()
        {
            String query = "Select * from Fuel_Consumption";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }
        public SqlCommand UpdateFuelCon(string NP, double LBT, double LAT, double Price, string FuelID)
        {
            string query = "UPDATE Fuel_Consumption SET Number_Plate = '" + NP + "', L_B_T = '" + LBT + "', L_A_T = '" + LAT + "', PPL = '" + Price + "' where FuelID = '" + FuelID + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }

        public SqlCommand LoadEmp_Rate()
        {
            String query = "Select * from Emp_Rate";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }
        public SqlCommand UpdateEmp_rate(string role, string name, string starttime, string endtime, double RPH, string Date, string RateID)
        {
            string query = "UPDATE Emp_rate SET Role= '" + role + "', Name = '" + name + "', StartTime = '" + starttime + "', EndTime = '" + endtime + "' , RPH = '" + RPH + "', Date = '" + Date + "' where RateID = '" + RateID + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }

        public void DeleteEmp_Rate(string name, string RateID)
        {
            string query = "DELETE FROM Emp_Rate WHERE Name = '" + name + "' AND RateID = '" + RateID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }
        public void DeleteLogin(string FirstName, string UserID)
        {
            string query = "DELETE FROM Login WHERE FirstName = '" + FirstName + "' AND EmpID = '" + UserID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }
        public void DeleteFuelCon(string Number_Plate, string FuelID)
        {
            string query = "DELETE FROM Fuel_Consumption WHERE Number_Plate = '" + Number_Plate + "' AND FuelID = '" + FuelID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }
        public void DeleteService(string po, string la)
        {
            string query = "DELETE FROM Service WHERE Vehicle_Make = '" + po + "' AND ServiceID = '" + la + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }
        public SqlCommand LoadTrip()
        {
            String query = "Select * from Trip";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }

        public SqlCommand UpdateTrip(string Name1, string Address1, string City1, string PC1, string Prov1, string Phone1, string Name2, string Address2, string City2, string PC2, string Prov2, string Phone2, string Desc2, string Status, string TID)
        {
            // 
            string query = "UPDATE Trip SET S_Name ='"+Name1+"', S_StreetAddress= '"+Address1+"', S_City = '"+City1+"', S_Postcode = '"+PC1+"', S_Province = '"+Prov1+"', S_Phone = '"+Phone1+"', R_Name ='"+Name2+"', R_StreetAddress= '"+ Address2 + "', R_City = '"+ City2 + "', R_Postcode = '"+ PC2 + "', R_Province = '"+ Prov2 + "', R_Phone = '"+ Phone2 + "', R_Description = '"+Desc2+"', Status = '"+Status+ "' where TripID = '"+TID+"' ";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd;
        }

        public SqlDataReader DisplayStaffName(String UserID)
        {
            String sql = "SELECT FirstName, LastName from Login where EmpID = '" + UserID + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader myReader;
            con.Open();
            myReader = cmd.ExecuteReader();
            return myReader;
        }
        public DataTable LoginUsername(String username)
        {
            String sql = "select Username from Login where Username = '" + username + "';";
            SqlDataAdapter sqlDA = new SqlDataAdapter(sql, con);
            DataTable UserAnswer = new DataTable("Username");
            sqlDA.Fill(UserAnswer);

            return UserAnswer;
        }

        public void ChangeIncTrip(String TripID)
        {

            String sql = "update Trip set Status = 'Stationary' where Status='Active' and TripID = '" + TripID + "'";

            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
        }
        public DataTable EmployeeReport()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select Role, Name, RPH, StartTime, EndTime, Date, Wage from Emp_Rate", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            return dt;

        }

        public DataTable ViewAllVehicles()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from Vehical", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            return dt;

        }
        public DataTable ViewServiceAppointment()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select * from Service where status = 'Pending'", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            return dt;

        }
        public DataTable ViewCompleteService()
        {
            SqlDataAdapter sda = new SqlDataAdapter("select s.Vehicle_Make, s.Vehicle_Model, s.Number_Plate, cs.Description, cs.Price from Service s, Complet_Service cs where cs.ServiceID = s.ServiceID and Status = 'Complete'", con);
            DataTable dt = new System.Data.DataTable();
            sda.Fill(dt);
            return dt;

        }

    }
}
