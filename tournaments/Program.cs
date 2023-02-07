// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Team firebirds = new Team("Firebirds");

Player john = new Player("John Henry", 12);
//john.Display();

Player tim = new Player("Tim Nunn", 13);

firebirds.AddPlayer(john);
firebirds.AddPlayer(tim);
firebirds.DisplayRoster();

Team firelizards = new Team("Firelizards");
Player bill = new Player("Bill John", 54);
Player jill = new Player("Jill John", 34);
firelizards.AddPlayer(bill);
firelizards.AddPlayer(jill);
firelizards.DisplayRoster();

Match match1 = new Match (firebirds, firelizards);
match1.DecideWin();

firebirds.DisplayRoster();
firelizards.DisplayRoster();