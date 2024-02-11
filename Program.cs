namespace mask
{
    class Program
    {
        static void Main()
        {
            // Your code here
            Console.WriteLine("Hello World! baby");
            //diziler /array
            string[] students = new string[3];
            students[0] = "Engin";
            students[1] = "Derin";  
            students[2] = "Salih";
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }
    } 
}
   

