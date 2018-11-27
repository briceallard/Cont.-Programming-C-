using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MdiWorkshop
{
    class Utilities
    {
        static public string STORE_NAME { get; set; }
        static public string STORE_FILE { get; set; }

        static public readonly string WORKING_PATH = System.AppDomain.CurrentDomain.BaseDirectory;
        static public readonly string DEFAULT_SAVE_PATH = Path.Combine(WORKING_PATH, "Stores");
        static public readonly string NEW_FILE_TYPE = ".sup";


        static public readonly string ERROR_INVALID_CHARS = "Invalid Characters Found!";
        static public readonly string MSG_INVALID_CHARS = "File name must contain only letters and numbers";

        static public readonly string ERROR_FILE_EXISTS = "File Exists!";
        static public readonly string MSG_FILE_EXISTS = "A file with this name already exists";

        static public readonly string ERROR_TITLE = "Error!";
        static public readonly string SUCCESS_TITLE = "Success!";
        static public readonly string MSG_FILE_CREATED = "File was created successfully";
        static public readonly string MSG_FILE_SAVED = "File was saved successfully";
    }
}
