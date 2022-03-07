using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvAddressBookLINQ
{
    public class AddressBookManager
    {
        public static DataTable dataTable;

        //UC2 - Method to create datatable with addressbook columns
        public static void CreateDataTable()
        {
            //Initializing the datatable
            dataTable = new DataTable("AddressBookLinq");
            DataColumn dataColumn;

            //Creating column addressbookId
            dataColumn = new DataColumn
            {
                DataType = typeof(int),
                ColumnName = "AddressBookId",
                Caption = "AddressBook Id",
                AutoIncrement = true,
                Unique = true
            };
            // Adding column to the DataColumn Collection 
            dataTable.Columns.Add(dataColumn);

            //Creating first name column.    
            dataColumn = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "FirstName",
                Caption = "First Name"
            };
            dataTable.Columns.Add(dataColumn);

            //Creating last name column.    
            dataColumn = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "LastName",
                Caption = "Last Name"
            };
            dataTable.Columns.Add(dataColumn);

            //Creating address column.    
            dataColumn = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "Address",
                Caption = "Address"
            };
            dataTable.Columns.Add(dataColumn);

            //Creating city column.    
            dataColumn = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "City",
                Caption = "City"
            };
            dataTable.Columns.Add(dataColumn);

            //Creating state column.    
            dataColumn = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "State",
                Caption = "State"
            };
            dataTable.Columns.Add(dataColumn);

            //Creating email column.    
            dataColumn = new DataColumn
            {
                DataType = typeof(string),
                ColumnName = "EmailId",
                Caption = "Email Id"
            };
            dataTable.Columns.Add(dataColumn);

            //Creating phone number column.    
            dataColumn = new DataColumn
            {
                DataType = typeof(long),
                ColumnName = "PhoneNumber",
                Caption = "Phone Number"
            };
            dataTable.Columns.Add(dataColumn);

            //Creating zipcode column.    
            dataColumn = new DataColumn
            {
                DataType = typeof(long),
                ColumnName = "ZipCode",
                Caption = "Zip Code"
            };
            dataTable.Columns.Add(dataColumn);
            Console.WriteLine("Created the datatable successfuly");
        }
    }
}
