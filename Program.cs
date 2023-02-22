using System.Transactions;

namespace PayrollArrays {
    internal class Program {
        static void Main(string[] args) {

            int employee = int.Parse(Input("Enter employee count:"));
            string[] employees = new string[employee];
            


            int[] hoursWorked = new int[employee];
            for (int i = 0; i < hoursWorked.Length; i += 1) {
                hoursWorked[i] = int.Parse(Input($"Enter hours for employee {i + 1} :"));


            }//END FOR
                Payroll(hoursWorked);
        }//END MAIN   
    
            static void Payroll(int[] array) {
            double payRate = double.Parse(Input("Enter the hourly rate :$"));
                    int pay = 0;
                    for (int index = 0; index < array.Length; index += 1) {
                      pay = array[index];
                      Console.WriteLine($"Employee {index + 1} :{pay * payRate:c}");
                    }//END FOR

            }//END FUNCTION
         
            static string Input(string prompt) {
                    Console.Write(prompt);
                    return Console.ReadLine();
            }//END FUNCTION

    }//end class
}//end namespace