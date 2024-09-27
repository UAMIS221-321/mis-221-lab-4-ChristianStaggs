//Main
DisplayMenu();
string userInput = ""; 
userInput = GetUserChoice();
RouteEm(userInput);
//End Main

//This method displays the first menu that pops up when the user runs the app.
static void DisplayMenu(){
    Console.Clear();
    System.Console.WriteLine("[1] Plain Pizza\n[2] Cheese Pizza\n[3] Pepporoni Pizza\n[4] Exit");
}

//This method reads the users choice that they input
static string GetUserChoice(){
    return Console.ReadLine();
}

//This method takes the users choice and directs the program to the section that the user wants to access
static void RouteEm(string userChoice){
    switch(userChoice){
        case "1":
            Plain();
            break;
        case "2":
            Cheese();
             break;
        case "3":
            Pepporoni();
             break;
        case "4":
             Cya();
             break;
        default:
             TrashInput();
             break;
    }
   
}

static void Plain(){
    for(int i = GetRandomNumber(); i >= 1; i--){
        for(int j = 0; j < i; j++){
            System.Console.Write("* ");
        }
        System.Console.WriteLine("");
    }
}

static void Cheese(){
   int ran = GetRandomNumber();
    for(int i = ran; i >= 1; i--){
        for(int j = 0; j < i; j++){
            if((j == 0) || (j == i-1) || (i==ran)){
                System.Console.Write("* ");
         }
         else{
            System.Console.Write("# ");
         }
        }
        System.Console.WriteLine("");
    }
}

static void Pepporoni(){
   int ran = GetRandomNumber();
    for(int i = ran; i >= 1; i--){
        for(int j = 0; j < i; j++){
             Random rnd = new Random();
            int num2 = rnd.Next(1,5);
            if((j == 0) || (j == i-1) || (i==ran)){
                System.Console.Write("* ");
         }
         else if(j == num2){
         System.Console.Write("[] ");

         }
         else{
            System.Console.Write("# ");
         }
        }
        System.Console.WriteLine("");
    }
}

static int GetRandomNumber(){
    Random rnd = new Random();
    int number = rnd.Next(8,13);
    return number;
}









//Allows the user to leave the program
static void Cya(){
    Console.Clear();
    System.Console.WriteLine("Cya later alligator");
}

//Writes a message when the user inputs a bad input
static void TrashInput(){
    Console.Clear();
    System.Console.WriteLine("Invalid Input >:( try again loser");
}