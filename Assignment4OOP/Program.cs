using System;
using System.Data;
using System.Net;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment4OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1:
            //Define an interface named IShape with a property Area and a method DisplayShapeInfo.Create two interfaces, ICircle and IRectangle, that inherit from IShape.Implement these interfaces in classes Circle and Rectangle. Test your implementation by creating instances of both classes and displaying their shape information.
}
        interface IShape
        {
            double Area { get; }
            void DisplayShapeInfo();
        }

        interface ICircle : IShape
        {
        }

        interface IRectangle : IShape
        {
        }

        class Circle : ICircle
        {
            private double _radius;

            public Circle(double radius)
            {
                _radius = radius;
            }

            public double Area
            {
                get { return Math.PI * _radius * _radius; }
            }

            public void DisplayShapeInfo()
            {
                Console.WriteLine($"Circle: Radius = {_radius}, Area = {Area:F2}");
            }
        }

        class Rectangle : IRectangle
        {
            private double _width;
            private double _height;

            public Rectangle(double width, double height)
            {
                _width = width;
                _height = height;
            }

            public double Area
            {
                get { return _width * _height; }
            }

            public void DisplayShapeInfo()
            {
                Console.WriteLine($"Rectangle: Width = {_width}, Height = {_height}, Area = {Area:F2}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Create instances of Circle and Rectangle
                Circle circle = new Circle(5);
                Rectangle rectangle = new Rectangle(4, 3);

                // Display shape information
                circle.DisplayShapeInfo();
                rectangle.DisplayShapeInfo();

                Console.ReadLine();

                #endregion
                #region
                //QuestionIn this example, 1 - We start by defining the IAuthenticationService interface with two methods: AuthenticateUser and AuthorizeUser.The BasicAuthenticationService class implements this interface and provides the specific implementation for these methods.2-In the BasicAuthenticationService class, the AuthenticateUser method compares the provided username and password with the stored credentials.It returns true if the user is authenticated and false otherwise.The AuthorizeUser method checks if the user with the given username has the specified role.It returns true if the user is authorized and false otherwise.3-In the Main method, we create an instance of the BasicAuthenticationService class and assign it to the authService variable of type IAuthenticationService.We then call the AuthenticateUser and AuthorizeUser methods using this interface reference..This implementation allows you to switch the authentication service implementation easily by creating a new class that implements the IAuthenticationService interface and providing the desired logic for authentication and authorization
                public interface IAuthenticationService
            {
                bool AuthenticateUser(string username, string password);
                bool AuthorizeUser(string username, string role);
            }

            public class BasicAuthenticationService : IAuthenticationService
            {
                // Replace with actual credential storage mechanism
                private static readonly Dictionary<string, string> _credentials = new Dictionary<string, string>()
    {
        { "user1", "password1" },
        { "user2", "password2" }
    };

                // Replace with actual role management logic
                private static readonly Dictionary<string, string> _userRoles = new Dictionary<string, string>()
    {
        { "user1", "User" },
        { "user2", "Admin" }
    };

                public bool AuthenticateUser(string username, string password)
                {
                    if (_credentials.TryGetValue(username, out string storedPassword) && storedPassword == password)
                    {
                        return true;
                    }
                    return false;
                }

                public bool AuthorizeUser(string username, string role)
                {
                    if (_userRoles.TryGetValue(username, out string userRole) && userRole == role)
                    {
                        return true;
                    }
                    return false;
                }
            }

            class Program
            {
                static void Main(string[] args)
                {
                    IAuthenticationService authService = new BasicAuthenticationService();

                    // Attempt to authenticate a user
                    bool isAuthenticated = authService.AuthenticateUser("user1", "password1");
                    Console.WriteLine($"User1 is authenticated: {isAuthenticated}");

                    // Check if the user has the Admin role
                    bool hasAdminRole = authService.AuthorizeUser("user2", "Admin");
                    Console.WriteLine($"User2 has Admin role: {hasAdminRole}");

                    Console.ReadLine();
                }
                #endregion
                #region 
                //Question 03:1-we define the INotificationService interface with a method SendNotification that takes a recipient and a message as parameters.2-We then create three classes: EmailNotificationService, SmsNotificationService, and PushNotificationService, which implement the INotificationService interface.3-In each implementation, we provide the logic to send notifications through the respective communication channel:4-The EmailNotificationService class simulates sending an email by outputting a message to the console.5-The SmsNotificationService class simulates sending an SMS by outputting a message to the console.6-The PushNotificationService class simulates sending a push notification by outputting a message to the console.7-In the Main method, we create instances of each notification service class and call the SendNotification method with sample recipient and message values.This implementation allows you to easily switch between different notification channels by creating new classes that implement the INotificationService interface and provide the specific logic for each channel
                public interface INotificationService
                {
                    void SendNotification(string recipient, string message);
                }

                public class EmailNotificationService : INotificationService
                {
                    public void SendNotification(string recipient, string message)
                    {
                        Console.WriteLine($"Sending email to {recipient}: {message}");
                    }
                }

                public class SmsNotificationService : INotificationService
                {
                    public void SendNotification(string recipient, string message)
                    {
                        Console.WriteLine($"Sending SMS to {recipient}: {message}");
                    }
                }

                public class PushNotificationService : INotificationService
                {
                    public void SendNotification(string recipient, string message)
                    {
                        Console.WriteLine($"Sending push notification to {recipient}: {message}");
                    }
                }

                class Program
                {
                    static void Main(string[] args)
                    {
                        // Create instances of each notification service
                        INotificationService emailService = new EmailNotificationService();
                        INotificationService smsService = new SmsNotificationService();
                        INotificationService pushService = new PushNotificationService();

                        // Send notifications
                        emailService.SendNotification("user@example.com", "This is an email notification.");
                        smsService.SendNotification("+1234567890", "This is an SMS notification.");
                        pushService.SendNotification("user_id", "This is a push notification.");

                        Console.ReadLine();
                    }
                    #endregion

                    #region 1.Define 3D Point Class and the basic Constructors (use chaining in constructors).

                    #region Attributes

                    private int x;
                    private int y;
                    private int z;






                    #endregion

                    #region Properties
                    public int Z
                    {
                        get { return z; }
                        set { z = value; }
                    }


                    public int Y
                    {
                        get { return y; }
                        set { y = value; }
                    }


                    public int X
                    {
                        get { return x; }
                        set { x = value; }
                    }

                    #endregion

                    #region Constructors
                    public Point3D(int _x, int _y, int _z)
                    {
                        X = _x;
                        Y = _y;
                        Z = _z;
                    }
                    public Point3D(int _x, int _y) : this(_x, _y, 0)
                    {

                    }

                    public Point3D(int _x) : this(_x, 0, 0)
                    {

                    }

                    public Point3D()
                    {
                        x = y = z = 0;
                    }

                    public Point3D(Point3D point)
                    {
                        X = point.X;
                        Y = point.Y;
                        Z = point.Z;
                    }
                    #endregion


                    #endregion

                    #region 2.Override the ToString Function to produce this output:
                    //  Point3D P = new Point3D(10, 10, 10);
                    //  Console.WriteLine(P.ToString( ));
                    //  Output: “Point Coordinates: (10, 10, 10)”.


                    public override string ToString()
                    {
                        return $"Point Coordinates: ({X} , {Y} , {Z})";
                    }


                    #endregion

                    #region 3. Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).

                    #region CreatePoint
                    public static Point3D CreatePoint()
                    {
                        int x, y, z;
                        bool flag01, flag02, flag03;

                        do
                        {
                            Console.Write("X = ");
                            flag01 = int.TryParse(Console.ReadLine(), out x);
                        } while (!flag01);

                        do
                        {
                            Console.Write("Y = ");
                            flag02 = int.TryParse(Console.ReadLine(), out y);
                        } while (!flag02);

                        do
                        {
                            Console.Write("Z = ");
                            flag03 = int.TryParse(Console.ReadLine(), out z);
                        } while (!flag03);

                        return new Point3D(x, y, z);
                    }

                    #endregion

                    #endregion

                    #region 4.Try to use == If(P1 == P2)   Does it work properly? 
                    /* == operator compare ref of objects if i want to 
                      To compare objects for their values so you have to 
                     overload ==  and != operators  
                    Or override Equals() and GetHashcode() methods */

                    public static bool operator ==(Point3D p1, Point3D p2)
                    {
                        return p1.x == p2.x && p1.y == p2.y && p1.z == p2.z;
                    }
                    public static bool operator !=(Point3D p1, Point3D p2)
                    {
                        return p1.x != p2.x || p1.y != p2.y || p1.z != p2.z;
                    }


                    public override bool Equals(object? obj)
                    {
                        Point3D? p = (Point3D?)obj;
                        return x == p.x && y == p.y && z == p.z;
                    }

                    public override int GetHashCode()
                    {
                        //return HashCode.Combine(x, y, z);
                        return base.GetHashCode() ^ (this.x.GetHashCode()) + (this.y.GetHashCode()) + (this.z.GetHashCode());
                    }

                    #endregion

                    #region Print Array
                    public static void Print(Point3D[] pointArr)
                    {
                        if (pointArr is null)
                        {
                            return;
                        }

                        for (int i = 0; i < pointArr.Length; i++)
                        {
                            Console.WriteLine(pointArr[i]);
                        }
                    }
                    #endregion

                    #region 5.Sort Array based on X & Y Coordinates

                    public static void SortPointArr(Point3D[] pointArr)
                    {
                        Array.Sort(pointArr);
                    }

                    public int CompareTo(object? obj)
                    {
                        Point3D? p = (Point3D?)obj;

                        if (p is not null)
                        {
                            if (x > p.x)
                                return 1;
                            else if (p.x > x)
                                return -1;

                            else
                                if (y > p.y)
                                return 1;
                            else if (p.y > y)
                                return -1;
                            else
                                return 0;
                        }
                        return 0;
                    }


                    #endregion

                    #region 6.Implement ICloneable interface to be able to clone the object.
                    public object Clone()
                    {
                        return new Point3D(this);
                    }

                    #endregion
                    #region 1.Define Class Maths that has four methods: Add, Subtract, Multiply, and Divide, each of them takes two parameters. Call each method in Main ().
                    //Math math = new Math();
                    //Console.WriteLine(math.Add(2,3));
                   // Console.WriteLine(math.Subtract(5, 3));
                    //Console.WriteLine(math.Multiply(2, 3));
                    //Console.WriteLine(math.Divide(3, 1));
                    #endregion
                    #region 2. Modify the program so that you do not have to create an instance of class to call the four methods.
                   // Console.WriteLine(Math.Add(2, 3));
                    //Console.WriteLine(Math.Subtract(5, 3));
                    //Console.WriteLine(Math.Multiply(2, 3));
                    //Console.WriteLine(Math.Divide(3, 1));
                    #endregion
                }
                tic void Main(string[] args)
                {
                    #region 3.Run All Required Constructors to Produce this output:
                    //Duration D1 =new Duration(1,10,15);
                    ////Output: Hours: 1, Minutes :10, Seconds :15

                    //Duration D1 = new Duration(3600);
                    ////Output: Hours: 1, Minutes :0, Seconds :0

                    //Duration D1 = new Duration(7800);
                    ////Output: Hours: 2, Minutes :10, Seconds :0

                    //Duration D1 = new Duration(666);
                    /////Output: Minutes :11, Seconds :6

                    //Console.WriteLine(D1);

                    #endregion

                    #region 4.Implement All required Operators overloading’s to enable this Code:
                    Duration D1 = new Duration(1, 10, 15);
                    ////Hours: 1, Minutes :10, Seconds :15

                    Duration D2 = new Duration(3600);
                    ////Hours: 1, Minutes :0, Seconds :0

                    Duration D3 = new Duration(7800);
                    ////Hours: 2, Minutes :10, Seconds :0
                    #region D3=D1+D2

                    //D3 = D1 + D2;
                    //Console.WriteLine(D3);

                    #endregion

                    #region D3 = D1 + 7800
                    //D3 = D1 + 7800;
                    //Console.WriteLine(D3);

                    #endregion

                    #region D3=666+D3
                    //D3 = 666 + D3;
                    //////Hours: 2, Minutes :10, Seconds :0
                    //Console.WriteLine(D3);
                    #endregion

                    #region D3 = ++D1 (Increase One Minute)

                    //D3 = ++D1;
                    //Console.WriteLine(D3);
                    #endregion

                    #region D3 = --D2 (Decrease One Minute)
                    //D3 = --D2;
                    //Console.WriteLine(D3);
                    #endregion

                    #region If(D1>D2) 
                    //if (D1 > D2)
                    //{
                    //    Console.WriteLine("D1>D2");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("D1<D2");
                    //}
                    #endregion

                    #region D1= D1 - D2
                    //D1 = D1 - D2;
                    //Console.WriteLine(D1);
                    #endregion

                    #region If(D1<=D2)
                    //if (D1 <= D2)
                    //{
                    //    Console.WriteLine("D1 <= D2");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("D1 >= D2");

                    //}
                    #endregion

                    #region If(D1)

                    //Duration D1 = new Duration();
                    //if (D1)
                    //    Console.WriteLine(D1);
                    //else
                    //    Console.WriteLine(new Duration());
                    #endregion

                    #region DateTime Obj = (DateTime)D1
                    //DateTime obj = (DateTime)D1;
                    //Console.WriteLine(obj);

                    #endregion

                    #endregion
                }
            
