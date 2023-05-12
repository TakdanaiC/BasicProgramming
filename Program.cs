using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ชนิดข้อมูลของ C#
 * 1.boolean = ค่าตรรกศาสตร์ 
 * 2.byte = ตัวเลขไม่มีทศนิยม (SByte(8))
 * 3.short = ตัวเลขที่ไม่มีจุดทศนิยม (Int16)
 * 4.int = ตัวเลขที่ไม่มีจุดทศนิยม (Int32)
 * 5.long = ตัวเลขที่ไม่มีจุดทศนิยม (Int64)
 * 6.float = ตัวเลขที่มีจุดทศนิยม (Single (32))
 * 7.double = ตัวเลขที่มีจุดทศนิยม (Double (64))
 * 8.char = ตัวอักษร (Char (16))
 
 */
/*
 * format string แสดงผลตัวเลข
 * E/e = Exponential (ตัวเลขชี้กำลัง)
 * F/f = Floating Point (เลขทศนิยม)
 * G/g = แสดงตัวเลขรูปแบบสั้นที่สุด
 * N/n = Number ใส่ comma ขั้นทุก 3 หลัก
 * P/p = Percentage (เลขเป็น %)
 * X/x = Hexadecimal (เลขฐาน 16)
 */
/*
 * ฟังก์ชั่นคณิตศาสตร์
 * Math.Abs(x) = ค่าสัมบูรณ์ของ x
 * Math.Ceiling(x) = ปัดเศษขึ่น
 * Math.Floor(x) = ปัดเศษลง
 * Math.Round(x) = if > .5 ปัดขึ้น , < .5 ปัดลง
 * Math.Pow(x,y) = x ยกกำลัง y
 * Math.Sqrt(x) = รากที่ 2 ของ X
 * Math.PI = ค่าคงที่ Pi = 3.141592653
 * Math.E = ค่าคงที่ E = 2.718281828
 */
/*
 * ตัวดำเนินการเปรียบเทียบ
 * == เท่ากับ
 * != ไม่เท่ากับ
 * > มากกว่า
 * < น้อยกว่า
 * >= มากกว่าหรือเท่ากับ
 * <= น้อยกว่าหรือเท่ากับ
 */
/*
 * เพิ่มค่า-ลดค่า
 * ++(prefix)_++a = add a then use
 * ++(postfix)_a++ = use a then add
 * --(prefix)_--b = minus b then use
 * --(postfix)_b-- = use b then
 */
namespace BasicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //นิยามตัวแปร int
            int x = 10;
            int y = 100;

            //float
            float a = 10.20f;
            float b = 10f;

            //double
            double number1;
            number1 = 500;
            double number2 = x + y;

            //boolean
            bool status1 = true;
            bool status2 = false;

            //char&string
            char al = 'A';
            string ai = "Takdanai";

            //const   const=ค่าคงที่ แก้ไขไม่ได้
            const int number = 500;
            //number = 1000;

            Console.WriteLine("Hello = {1}", "Takdanai", "Ice"); //ใช้ {} เพื่อกำหนดลำดับการแสดงผล เริ่มต้นที่ 0
            //Print Write=แสดงเฉยๆ WriteLine=แสดงแล้วขึ้นบรรทัดใหม่
            int number3 = 12000;
            Console.WriteLine("Format String");
            Console.WriteLine("Number = {0}", number3);
            Console.WriteLine("Number = {0:E}", number3);
            Console.WriteLine("Number = {0:F}", number3);
            Console.WriteLine("Number = {0:G}", number3);
            Console.WriteLine("Number = {0:N}", number3);
            Console.WriteLine("Number = {0:P}", number3);
            Console.WriteLine("Number = {0:X}", number3); 

             //Read&Readline
             Console.WriteLine("input output");
             Console.Write("Input = ");
             //int result = Console.Read(); //ascii code
             string result = Console.ReadLine();
             Console.WriteLine("Output = {0}", result);
             Console.ReadKey(); 

             //ตัวดำเนินการทางคณิต
             Console.WriteLine("math");
             int d = 10;
             double e = 100.2;
             int g = 5;
             int h = 20;
             int i = 2;
             double f = e * d / g + h - i;
             Console.WriteLine("Result = {0}", f);
             Console.ReadKey(); 

            //ฟังก์ชั่นคณิตศาสตร์
            Console.WriteLine("math function");
            float number4 = 15.49f;
            float result2 = Math.Abs(number4);
            Console.WriteLine("Abs = {0}", Math.Abs(number4));
            Console.WriteLine("Ceiling = {0}", Math.Ceiling(number4));
            Console.WriteLine("Floor = {0}", Math.Floor(number4));
            Console.WriteLine("Round = {0}", Math.Round(number4));
            Console.WriteLine("Power = {0}", Math.Pow(5, 2));
            Console.WriteLine("Square Root = {0}", Math.Sqrt(9));
            Console.WriteLine("PI = {0}", Math.PI);
            Console.WriteLine("E = {0}", Math.E); 

             //เปรียบเทียบ
             Console.WriteLine(">/<");
             int number5 = 2, number6 = 3;
             bool result3 = number5 == number6;
             Console.WriteLine(result3); 
             Console.WriteLine(number5 == number6); //แสดง False
             Console.WriteLine(number5 != number6); // True
             Console.WriteLine(number5 > number6); // False
             Console.WriteLine(number5 < number6); // True
             Console.ReadLine(); 

             //prefix&postfix
             Console.WriteLine("Prefix&Postfix");
             int j = 5, k = 10;
             // ++
             Console.WriteLine("j = {0}", j); //5
             Console.WriteLine("Prefix = {0}", ++j ); //6
             Console.WriteLine("last j = {0}", j); //6
             j = 5;
             Console.WriteLine("j = {0}", j); //5
             Console.WriteLine("Postfix = {0}", j++); //5
             Console.WriteLine("last j = {0}", j); //6
             Console.ReadKey(); 

             //Compund Assignment (ลดรูป)
             Console.WriteLine("compound");
             int l = 5, m = 10;
             l += m; // l = l+m  
             Console.WriteLine(l);
             Console.ReadKey(); 

             //ลำดัยสำคัญ
             Console.WriteLine("math priority");
             float result5 = 5 * 2 - 40 / 5; //ได้ 2 เพราะ คูณ-หาร มาก่อน บวก-ลบ
             Console.WriteLine("Result = {0}", result5);
             Console.ReadKey(); 

             //type casting
             Console.WriteLine("convert");
             //รับค่า
             String myString = "120";
             //แปลงข้อมูลตัวเลข
             byte myByte = (byte)Convert.ToSByte(myString);
             short myShort = (short)Convert.ToInt16(myString);
             int myInt = (int)Convert.ToInt32(myString);
             long myLong = (long)Convert.ToInt64(myString);
             //ทศนิยม
             float myFloat = Convert.ToSingle(myString);
             double myDouble = Convert.ToDouble(myString);
             //แปลงเลขเป็นข้อมูล
             string result4 = Convert.ToString(myDouble);
             //แสดงผล
             Console.WriteLine("string = {0}", myString+100);
             Console.WriteLine("byte = {0}", myByte);
             Console.WriteLine("short = {0}", myShort +100);
             Console.WriteLine("int = {0}", myInt + 1000);
             Console.WriteLine("long = {0}", myLong);
             Console.WriteLine("float = {0}", myFloat + 50);
             Console.WriteLine("double = {0}", myDouble);
             Console.WriteLine("double to string = {0}", result4+100);
             Console.ReadKey(); 

              //Parse
              Console.WriteLine("Convert with Parse");

              //input
              string myString1 = "200.15"; //Parse ส่งค่าได้แค่ String เท่านั้น
              double myNumber = 500;
              //process
              double myDouble1;
              bool check = double.TryParse(myString1, out myDouble);
              byte myByte1 = byte.Parse(myString1);
              short myShort1 = short.Parse(myString1);
              short myShortConvert = Convert.ToInt16(myNumber); //Convert สามารถทำงานได้หลากหลาย ไม่ตายตัว


              bool myBoolean = true;
              string myConvert = Convert.ToString(myBoolean);
              Console.WriteLine("result = {0}", myConvert);


              //output
              Console.WriteLine("success = {0}", myDouble);
              Console.WriteLine("check = {0}", check);
              Console.WriteLine("int = {0}", myInt);
              Console.WriteLine("string = {0}", myString1+100);
              Console.WriteLine("byte = {0}", myByte1+100);
              Console.WriteLine("short = {0}", myShort1+100);
              Console.ReadKey(); 

            //widening&narrowing casting
            double p = 100.15;
            int o = (int)x;
            Console.WriteLine(y);
            Console.ReadKey();

            //if statement


             string name = "JoJo";

             if (name=="kong")
             {
                 //คำสั่งต่างๆ
                 Console.WriteLine("Hello , Admin");
             }
             else
             {
                 //หาก if เป็นเท็จ
                 Console.WriteLine("Hello User, {0}", name);
             } 

              int age = 10;
              if (age>15)
              {
                  Console.WriteLine("I'm Teen");
              }
              else
              {
                  Console.WriteLine("I'm a Child");
              } 
            int ifnumber;
            Console.Write("Input Number = ");
            int.TryParse(Console.ReadLine(), out ifnumber);
            if (ifnumber % 2 == 0)
            {
                //หารลงตัว => เลขคู่
                Console.WriteLine("{0} = Even Number", ifnumber);
            }
            else
            {
                //หารไม่ลงตัว => เลขคี่
                Console.WriteLine("{0} = Odd Number", ifnumber);
            }
            Console.WriteLine("End Program");
            Console.ReadKey();
            

            //Multiple If/Else

            //input
            int score;
            Console.Write("Input Score = ");
            int.TryParse(Console.ReadLine(), out score);

            //process & output
            if (score>=80)
            {
                Console.WriteLine("Grade A");
            } else if (score>=70)
            {
                Console.WriteLine("Grade B");
            } else if (score>=60)
            {
                Console.WriteLine("Grade C");
            } else if (score>=50)
            {
                Console.WriteLine("Grade D");
            } else
            {
                Console.WriteLine("Grade F");
            }


            //AND OR NOT
            string gender = "female";
            int height = 160;

            if (gender == "male" || height >=160)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Fail");
            }

            int age1 = 20;
            if (!(age1 >= 18))
            {
                Console.WriteLine("I'm not an Adult");
            }else
            {
                Console.WriteLine("I'm an Adult");
            }

            int score1 = 40;
            string result1;
            result1 = (score1 >= 50) ? "Pass" : "Not Pass";
            Console.WriteLine("Status = {0}", result1);

            //if in if
            int money = 30000;
            if (money>=15000)
            {
                Console.WriteLine("Sale");
                if (money == 15000)
                {
                    Console.WriteLine("Sale = 10%");
                }
                else if (money == 20000)
                {
                    Console.WriteLine("Sale = 20%");
                }
                else if (money == 30000)
                {
                    Console.WriteLine("Sale = 30%");
                }

                   
            }
            else
            {
                Console.WriteLine("Not Sale");
            }

            Console.ReadKey();


        }
    }
}
