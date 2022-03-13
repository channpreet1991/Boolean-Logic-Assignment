#include <stdio.h>
int main() {
   float weight, width, height, length, quote;
   Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");
   Console.WriteLine("Please enter the package weight:\n");
   scanf("%f", &weight);
   if(weight > 50) {
       Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
       return 0;
   }
   Console.WriteLine("Please enter the package width:\n");
   scanf("%f", &width);
   Console.WriteLine("Please enter the package height:\n");
   scanf("%f", &height);
   Console.WriteLine("Please enter the package length:\n");
   scanf("%f", &length);
   if(width+height+length > 50) {
       Console.WriteLine("Package too big to be shipped via Package Express.");
       return 0;
   }
   quote = width*height*length*weight/100;
   Console.WriteLine("Your estimated total for shipping this package is: $%.2f\n Thank you.", quote);
   return 0;
}