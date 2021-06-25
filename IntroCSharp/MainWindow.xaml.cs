using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/// <summary>
/// --------------------------------INTRODUCTION--------------------------------
/// C# is an object-oriented, strongly typed, programming language originally developed
/// by Microsoft for use in business/enterprise level applications. It has come a long
/// way from its initial purpose, and can now be used for mobile applications, games,
/// and web-based applications.
/// 
/// If you are familiar with any coding languages, I'd say Java is very similar to
/// C#. And although C# is based on C++, which was originally built as an extension to C,
/// C# shares many features and functions with Java along with C++.
/// 
/// To start, we should go over how C# code is structured and organized.
/// </summary>
/// 

namespace IntroCSharp /* C# code is organized into units of code called namespaces, classes, and methods.
                       * This here is a namespace called IntroCSharp. Notice how it shares the same name
                       * as the project. This namespace basically tells us that all the code inside of it
                       * belongs to the project it is named after. As such, the namespace basically serves as
                       * a container for our code.
                       */
{
    public partial class MainWindow : Window /* This is a class. We can only place classes inside of a namespace.
                                              * A class is a specialized unit of code designed for an "object".
                                              * 
                                              * A class provides details about the object, such as properties,
                                              * methods, variables, and other class members.
                                              * 
                                              * An object could be something like a window as shown here, or it could
                                              * be a bank account, a server, a student, a database, and many other things.
                                              * 
                                              * So what defines an object? Basically, an object is something with
                                              * properties and behaviors attached to it (bank account can close,
                                              * server can receive requests, student has a name, etc.).
                                              * 
                                              * If you wanted to create a web application, you would probably
                                              * need several classes—or objects. You'd probably have a class
                                              * to handle connecting to the Internet, a class to connect to a
                                              * database, a class to handle requests, and so on.
                                              * 
                                              * By using classes, we can organize code into named units so
                                              * it is easier to understand and manage, especially once
                                              * the application gets larger.
                                              */

    { /* You might have noticed these curly braces everywhere.
       * Well these curly braces determine the scope of namespaces,
       * classes, and methods. Everything with the curly braces
       * belongs to the unit it is named after.
       * e.g.
       * 
       * class Student{
       * All the code in here belongs to the Student class
       * }
       * 
       * namespace IntroCSharp{
       * All the code in here belongs to the IntroCSharp namespace
       * }
       * 
       * The { stands for the beginning of the code. The } marks
       * the end of the code.
       */
        public MainWindow() /* This is a method declaration. Recall that a namespace can
                             * only contain classes. A class can hold methods,
                             * variables, properties, fields, and other class members.
                             * 
                             * All methods have an accessibilty level or
                             * an access modifier keyword (public, private,
                             * protected, etc.). This determines whether other
                             * classes can view and use the method.
                             * Public means other classes can use it, private
                             * indicates no. They are also marked with () to
                             * allow values to be passed into it if needed.
                             * 
                             * So, what exactly is a method?
                             * A method defines a certain behavior of a class/object.
                             * If we had a class called BankAccount, we could add
                             * methods like Deposit() or CheckBalance() to deposit
                             * money or check a balance, respectively.
                             * 
                             * In this MainWindow class, we have two methods: MainWindow()
                             * and WelcomeMessage().
                             */
        {

            /* These statements are contained within the MainWindow()
             * method. Notice how they are inside the two {} associated
             * with the method, indicating that they belong to it.
             * This means these statements below will execute whenever
             * the MainWindow() method is called.
             */
            InitializeComponent();

            WelcomeMessage();
        }

        /// <summary>
        /// Here is another method. This method belongs to the MainWindow
        /// class and the IntroCSharp namespace, as indicated by the two
        /// outer curly braces.
        /// </summary>
        private void WelcomeMessage() /* This is the method signature/declaration.
                                       * The first keyword is the accessibility level.
                                       * The second keyword is the return type. This indicates
                                       * what kind of values the method is expected to work with
                                       * and return. Void means no real value, string is a string,
                                       * double is a double, and so on.
                                       * The third part is the method name. This is what we will
                                       * call whenever we use the method in our code, like
                                       * in the MainWindow() method shown above.
                                       */
        {
            // The statements below are contained within the WelcomeMessage()
            // method. This means they will execute whenever the method
            // is called.

            string welcome = "Hello there!"; /* This is a statement. Specifically, we are
                                              * declaring a string variable named "welcome".
                                              * We are then assigning the value "Hello there!"
                                              * to the variable welcome. By doing this, we
                                              * don't have to retype "Hello there!". We can
                                              * instead just use the variable name "welcome".
                                              */

            MessageBox.Show(welcome); /* This is a good example of methods, variables,
                                       * and classes in action.
                                       * 
                                       * Notice how the statement has four parts:
                                       * -MessageBox
                                       * -.
                                       * -Show()
                                       * -welcome
                                       * 
                                       * The MessageBox portion indicates that the
                                       * following code comes from the MessageBox class.
                                       * The . is a break to allow us to select a method, property,
                                       * field, and other class member from the MessageBox class.
                                       * In this case, it's the Show() method. Then we can pass the
                                       * variable "welcome" into it, which will display the text
                                       * "Hello there!" to the user in a message box.
                                       * 
                                       * Similarly, if we were in another class and wanted to use
                                       * the WelcomeMessage() method of the MainWindow class, we
                                       * would do the following:
                                       * MainWindow.WelcomeMessage();
                                       * 
                                       * We have a few other things to add if we want the above statement
                                       * to work, but hopefully that makes some sense.
                                       */
        }
    }
}
