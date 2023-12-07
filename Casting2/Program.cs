using System.Collections;

namespace Casting2
{



    class Program
    {
        public static void Main(String[] args)
        {
            Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 990;

            Console.WriteLine(text.Width);

            //automatically upcast
            StreamReader sReader = new StreamReader(new MemoryStream()); //pass any object derived from the string class
        
            ArrayList list = new ArrayList();
            var list2 = new ArrayList();

            list2.Add(1); //take any object, this is not typesafe
            list2.Add("text"); 
            list2.Add(new object());

            var genericList = new List<int>();
            genericList.Add(1);
            genericList.Add(2);
            genericList.Add(3);


            var genericListText = new List<string>();
            genericListText.Add("Text");
            genericListText.Add("Text2");

            var genericListShape = new List<Shape>();
            genericListShape.Add(new Shape());
            genericListShape.Add(new Shape());
            genericListShape.Add(new Shape());


            Shape shape3 = new Text();
            // shape3 cant access to text properties so I have to downcast

            Text textX = (Text)shape3;

            textX.FontName = "Text Font";    
              

        
        }
    }
}