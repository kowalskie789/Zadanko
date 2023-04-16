
/*
//EXERCISE 6
Assume that C# don’t have generic list.
Implement generic MyClass list based on array.
*/

using ConsoleApp2;

MyList<int> lista = new MyList<int>();
lista.InsertData(3);
lista.InsertData(5);
lista.InsertData(6);
lista.InsertData(7);
lista.Print();

MyList<string> lista2 = new MyList<string>();
lista2.InsertData("ELO");
lista2.InsertData("CODECOOLERZY");
lista2.InsertData("!!!!!!!!!!!!!!!");
lista2.InsertData("!!!!!!!!!!!!!");
lista2.InsertData("!!!!!!!!!!!!");
lista2.InsertData("!!!!!!!!!!!");
lista2.InsertData("!!!!!!!!!!");
lista2.InsertData("!!!!!!!!!");
lista2.InsertData("!!!!!!!!");
lista2.InsertData("!!!!!!!");
lista2.InsertData("!!!!!!");
lista2.InsertData("!!!!!");
lista2.InsertData("!!!!");
lista2.InsertData("!!!");
lista2.InsertData("!!");
lista2.InsertData("!");
lista2.Print();