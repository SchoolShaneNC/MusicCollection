using System.ComponentModel.DataAnnotations;

namespace MVC_Music.ViewModels
{
    public class PerformanceReportVM
    {
        public int ID { get; set; } 
        public string First_Name { get; set; } = "";
        public string? Middle_Name { get; set; } = "";
        public string Last_Name { get; set; } = "";

        [Display(Name = "Musician")]
        public string FormalName
        {
            get
            {
                return Last_Name + ", " + First_Name
                    + (string.IsNullOrEmpty(Middle_Name) ? "" :
                        (" " + (char?)Middle_Name[0] + ".").ToUpper());
            }
        }


        [Display(Name = "Average Fee Paid")]
        [DataType(DataType.Currency)]
        public double? Average_Fee_Paid { get; set; }

        [Display(Name = "Highest Fee Paid")]
        [DataType(DataType.Currency)]
        public double? Highest_Amount_Paid { get; set; }

        [Display(Name = "Lowest Fee Paid")]
        [DataType(DataType.Currency)]
        public double? Lowest_Fee_Paid { get; set; }

        [Display(Name = "Total Number of Performances")]
        public int? Total_Number_of_Performances {  get; set; }

        [Display(Name = "Total Number of Songs Performed On")]
        public int? Total_Number_of_Songs_Preformed {  get; set; }




    }
}
