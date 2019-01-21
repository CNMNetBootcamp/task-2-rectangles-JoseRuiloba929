using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup
            Single triangle1Height = 0;
            Single triangle1Width = 0;
            Single triangle2Height = 0;
            Single triangle2Width = 0;
            Single triangle1Area = 0;
            Single triangle2Area = 0;
            string inputValue = string.Empty;
            string tryAgain = string.Empty;
            string resultant = null;
            bool isString = true;

            //input
            do
            {
                    do
                    {
                        Console.WriteLine("Please enter the height of the first triangle");
                        inputValue = Console.ReadLine();
                        isString = Single.TryParse(inputValue, out triangle1Height);

                        if (!isString)
                        {
                            Console.WriteLine("You entered a string value, Please enter a valid number");
                        }
                    } while (!isString);

                    do
                    {
                        Console.WriteLine("Please enter the width of the first triangle");
                        inputValue = Console.ReadLine();
                        isString = Single.TryParse(inputValue, out triangle1Width);

                        if (!isString)
                        {
                            Console.WriteLine("You entered a string value, Please enter a valid number");
                        }
                    } while (!isString);
                    do
                    {
                        Console.WriteLine("Please enter the height of the second triangle");
                        inputValue = Console.ReadLine();
                        isString = Single.TryParse(inputValue, out triangle2Height);

                        if (!isString)
                        {
                            Console.WriteLine("You entered a string value, Please enter a valid number");
                        }
                    } while (!isString);

                    do
                    {
                        Console.WriteLine("Please enter the width of the second triangle");
                        inputValue = Console.ReadLine();
                        isString = Single.TryParse(inputValue, out triangle2Width);

                        if (!isString)
                        {
                            Console.WriteLine("You entered a string value, Please enter a valid number");
                        }
                    } while (!isString);

                    //process
                    triangle1Area = triangleArea(triangle1Height, triangle1Width);
                    triangle2Area = triangleArea(triangle2Height, triangle2Width);


                    //output
                    if (triangle1Area > triangle2Area)
                    {
                        resultant = "The area of the first triangle " + triangle1Area + " is larger than the second triangle " + triangle2Area;
                    }
                    else if (triangle1Area < triangle2Area)
                    {
                        resultant = "The area of the second triangle " + triangle2Area + " is larger than the first triangle " + triangle1Area;
                    }
                    else
                    {
                        resultant = "Both triangles have equal area" + triangle1Area;
                    }

                    Console.WriteLine(resultant);
                    Console.ReadLine();
                    Console.WriteLine("Do you want to do this again? Y or N");
                    tryAgain = Console.ReadLine().ToUpper();
  
            } while (tryAgain == "Y");
        }
        private static float triangleArea(float triangleHeight, float triangleWidth)
        {
            return .5f * triangleHeight * triangleWidth;
        }
    }
}
