namespace Project
{
    class person_Nl
    {
        public string Name { get; set;}
        public string Lastname { get; set;}     
        public int age {get; set;}

        public void Printallinformation()
        {

            Console.WriteLine($"Имя студента: {Name}");
            Console.WriteLine($"Фамилия или Отчество студента: {Lastname}");
            Console.WriteLine($"Возраст студента: {age}");
        }
    }
    class student : person_Nl
    {
        public bool Working {get; set;}

        public void busy()
        {
            if (Working)
            {

                Console.WriteLine("Cтудент занят,обратитесь попозже");
            }
            else
            {
                Console.WriteLine("Студент свободен");
            }

        }

    }
    class holp
    {
        public static void Main(string[] args)
        {

            student Info = new student
            {

                Working = true,
                Name = "Dias",
                Lastname = "Bissenbayev",
                age = 18,
       
            };

            Info.busy();
            Info.Printallinformation();

                
            
  
        }

    }



}