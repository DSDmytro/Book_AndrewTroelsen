using System;
using System.Windows.Forms; 
class TestApp
{
static void Main ()
{
Console.WriteLine("Testing! 1, 2, 3");
//MessageBox.Show("Hello");
//Используем класс HelloMessage
HelloMessage h = new HelloMessage();
h.Speak();
}
}