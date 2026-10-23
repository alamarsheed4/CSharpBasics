using System;

namespace interfacebasics{

    interface Interface1{

        int age{get; set;}

        string name{get; set;}
        int getAge();

        string getName();

        void getMessage();

        void getEmployeeByID(int empID);
    }

    interface Interface3{
        void getEmployeeByLocation(string location);
    }
    interface Interface2 : Interface1 , Interface3
    {

        int getEmployeeList();
    }
}