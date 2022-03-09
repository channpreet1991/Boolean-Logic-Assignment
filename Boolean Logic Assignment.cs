#include <iostream>
using namespace std;
int main() {
  int age, speedingTickets;
  string DUI;
  cout<<" What is your age? "<<endl;
  cin>>age;
  cout<<" Have you ever had a DUI? "<<endl;
  cin>>DUI;
  cout<<" How many speeding tickets do you have? "<<endl;
  cin>>speedingTickets;
  bool ans;
  if(age>15 && DUI=="false" && speedingTickets<=3){
    cout<<"Qualified ?"<<endl;
    cout<<"true"<<endl;
    ans = true;
  }
  else{
    cout<<"Qualified ?"<<endl;
    cout<<"false"<<endl;
    ans = false;
  }
  return ans; // if exit status is 1 then true
}