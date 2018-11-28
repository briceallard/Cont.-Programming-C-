/**
 * Brice Allard
 * Contemporary Programming - C#
 * Dr. Stringfellow
 * 11-27-2018
 * 
 * Inventory Solution Software designed with MDI in mind. One parent form
 * and multiple child forms to maintain the inventory of several locations
 * at once. Menu items are demonstrated as well as sort and serialization
 * for easy data management and file storage.
 **/

using System.IO;

namespace MdiWorkshop
{
    /// <summary>
    /// Helper file! Helper file! Helper file!
    /// </summary>
    class Utilities
    {
        static public string STORE_NAME { get; set; }
        static public string STORE_FILE { get; set; }

        static public readonly string WORKING_PATH = System.AppDomain.CurrentDomain.BaseDirectory;
        static public readonly string DEFAULT_SAVE_PATH = Path.Combine(WORKING_PATH, "Stores");
        static public readonly string NEW_FILE_TYPE = ".sup";


        static public readonly string ERROR_INVALID_CHARS = "Invalid Characters Found!";
        static public readonly string MSG_INVALID_CHARS = "File name must contain only letters and numbers";

        static public readonly string ERROR_EMPTY_FIELDS = "Empty Fields!";
        static public readonly string MSG_EMPTY_FIELDS = "Please enter a value in all fields";

        static public readonly string ERROR_FILE_EXISTS = "File Exists!";
        static public readonly string MSG_FILE_EXISTS = "A file with this name already exists";

        static public readonly string ERROR_ENTRY_EXISTS = "Entry Exists!";
        static public readonly string MSG_ENTRY_EXISTS = "Cannot have duplicate SKU values";

        static public readonly string ERROR_TITLE = "Error!";
        static public readonly string SUCCESS_TITLE = "Success!";
        static public readonly string MSG_FILE_CREATED = "File was created successfully";
        static public readonly string MSG_FILE_SAVED = "File was saved successfully";
    }
}
