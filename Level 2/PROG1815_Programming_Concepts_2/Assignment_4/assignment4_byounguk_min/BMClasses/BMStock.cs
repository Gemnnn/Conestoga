using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4_byounguk_min
{
    class BMStock
    {
        #region constructors
        public BMStock() { }
        #endregion

        #region properties
        public int StockId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Double Price { get; set; }
        public int Minutes { get; set; }
        public Boolean IsProcedure { get; set; }
        #endregion

        #region variables
        public static string record, fileName = "Stock.txt", archive = "Archive.txt";
        static StreamWriter writer;
        static StreamReader reader;
        #endregion

        #region Add, Update, Delete methods

        // It assigns a unique StockId to the object and adds the user's record to the file.
        public void BMAdd()
        {
            BMEdit();

            File.Copy(fileName, archive, true);

            List<int> number = new List<int>();
            try
            {
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        int index = record.IndexOf('\t');

                        number.Add(Convert.ToInt32(record.Substring(0, index).Trim()));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception (" : Add reader processing error - " + ex.Message);
            }
            if (number.Count == 0)
            {
                StockId = 1;
            }
            else if (number.Contains(1) && number.Count == 1)
            {
                StockId = 2;
            }
            else
            {
                for (int i = 1; i <= number.Max(); i++)
                {
                    if (!number.Contains(i))
                    {
                        StockId = i;
                        break;
                    }
                    else
                    {
                        StockId = i + 1;
                    }
                }
            }
            try
            {
                using (writer = new StreamWriter(fileName, append: true))
                {
                    writer.WriteLine(ToString());
                }
            }
            catch (Exception ex)
            {

                throw new Exception (" : Add wirter processing error - " + ex.Message);
            }
        }

        // Update the information user's changed
        public void BMUpdate()
        {
            BMEdit();

            File.Copy(fileName, archive, true);

            var newRecord = BMGetStocks();

            try
            {
                using (writer = new StreamWriter(fileName, append: false))
                {
                    newRecord.ForEach(oldRecord =>
                    {
                        if (oldRecord.StockId == StockId)
                        {
                            oldRecord.Name = Name;
                            oldRecord.Description = Description;
                            oldRecord.IsProcedure = IsProcedure;
                            oldRecord.Price = Price;
                            oldRecord.Minutes = Minutes;
                        }
                        writer.WriteLine(oldRecord.ToString());
                    });    
                }
            }
            catch (Exception ex)
            {
                throw new Exception(" : Update processing error - " + ex.Message);
            }
        }


        // Delete the selected record
        // If there is no saved record, an error message is displayed
        public static void BMDelete(string number)
        {
            File.Copy(fileName, archive, true);

            var stocks = BMGetStocks();

            if (Convert.ToInt32(number) == 0)
            {
                throw new Exception("There is no data to be deleted.");
            }

            try
            {
                using (writer = new StreamWriter(fileName, append: false))
                {
                    stocks.ForEach(items =>
                    {
                        if (items.StockId != Convert.ToInt32(number))
                        {
                            writer.WriteLine(items.ToString());
                        }
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(" : Delete processing error - " + ex.Message);
            }

        }
        #endregion

        #region utilities: Edit, ToString, Parse, VerifyFile

        // Validate the data entered by the user
        // The name and description are checked for null and trimmed
        // It Checks that data cannot be updated with a duplicate name
        // After all validations are done, the Add or Update function proceeds depending on the StockId
        private void BMEdit()
        {
            string errors = "";
            bool containName = false;

            List<BMStock> stocks = BMGetByDescription(Name);

            foreach (var stock in stocks)
            {
                if (StockId != stock.StockId && Name == stock.Name)
                {
                    containName = true;
                    break;
                }
            }   

            // Name
            Name = (Name + "").Trim();
            if (Name == "")
            {
                errors += "Stock's Name must be entered.\n";
            }
            else if (containName)
            {
                errors += "Stock's Name already exists\n";
            }

            // Description
            Description = (Description + "").Trim();
            if (Description == "")
            {
                errors += "Description must be entered.\n";
            }
            
            // Price
            if (Price < 0)
            {
                errors += "Price can not be less than zero.\n";
            }

            // Minutes
            if (IsProcedure == true && Minutes <= 0)
            {
                errors += "If Procedure is checked, Minutes must be greater than zero.\n";
            }
            if (IsProcedure == false && Minutes != 0)
            {
                errors += "If Procedure is unchecked, Minutes must be zero.\n";
            }

            if (errors != "")
            {
                throw new Exception(errors);
            }
        }

        // It Converts the input to the desired format
        public override string ToString()
        {
            return $"{StockId}\t{Name}\t{Description}\t{Price}\t" +
                $"{Minutes}\t{IsProcedure}";
        }

        /// <summary>
        /// It organizes the entered records according to their own position
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static BMStock BMParse(string input)
        {
            string[] fields = input.Split('\t');
            BMStock bMstocks = new BMStock()
            {
                StockId = Convert.ToInt32(fields[0]),
                Name = fields[1],
                Description = fields[2],
                Price = Convert.ToDouble(fields[3]),
                Minutes = Convert.ToInt32(fields[4]),
                IsProcedure = Convert.ToBoolean(fields[5]),
            };
            return bMstocks;
        }

        // Create a file that can save or load user records
        public static void VerifyFile()
        {
            try
            {
                if (!File.Exists(fileName))
                {
                    File.Create(fileName).Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(" : Verifying file processing error - " + ex.Message);
            }
        }
        #endregion

        #region Get Methods

        /// <summary>
        /// Returns all items as a list without parameters
        /// It is used to displays a Listbox, update data and delete data
        /// </summary>
        /// <returns></returns>
        public static List<BMStock> BMGetStocks()
        {
            VerifyFile();
            List<BMStock> stocks = new List<BMStock>();
            try
            {
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        stocks.Add(BMParse(record));
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(" : Get stocks processing error - " + ex.Message);
            }

            return stocks;
        }

        /// <summary>
        /// It accepts an integer parameter and returns an object with a StockId equal to the given integer
        /// It is used when the data selection of the list box is changed
        /// </summary>
        /// <param name="stockId"></param>
        /// <returns></returns>
        public static BMStock BMGetByStockId(int stockId)
        {
            BMStock stock = null;

            try
            {
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        if (record.StartsWith(stockId.ToString() + "\t"))
                        {
                            stock = BMParse(record);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(" : Get stock id processing error - " + ex.Message);
            }
            return stock;
        }

        /// <summary>
        /// Returns a List of all Stocks containing the string phrase specified in Name or Description
        /// It is used when using Edit validation
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<BMStock> BMGetByDescription(string input)
        {
            List<BMStock> stock = new List<BMStock>();

            try
            {
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        record = reader.ReadLine();
                        string[] fields = record.Split('\t');

                        if (fields[1] == input || fields[2].Contains(input))
                        {
                            stock.Add(BMParse(record));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(" : Get description processing error - " + ex.Message);
            }
            return stock;
        }
        #endregion
    }
}
