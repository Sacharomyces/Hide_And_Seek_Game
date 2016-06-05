using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_str_376__Zduduj_dom_2._0_
{
    public partial class Form1 : Form
    {
        Opponent ty;
        Location currentLocation;

        RoomWithDoor livingRoom;
        RoomWithDoor kitchen;

        Room diningRoom;
        Room stairs;

        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace smallBedroom;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace hall;

        Outside garden;

        OutsideWithDoor backYard;
        OutsideWithDoor frontYard;

        OutsideWithHidingPlace driveway;


        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToNewLocation(livingRoom );
            newGameScreen();
        }
        private int moves = 0;

        public void CreateObjects()
        {
           


            livingRoom = new RoomWithDoor("Salon", "pod kanapą");
            kitchen = new RoomWithDoor("Kuchnia", "w lodówce");

            diningRoom = new Room("Jadalnia");
            stairs = new Room("Schody");

            hall = new RoomWithHidingPlace("Hol na piętrze", "szafie");
            masterBedroom = new RoomWithHidingPlace("Duża sypialnia", "pod łóżkiem");
            smallBedroom = new RoomWithHidingPlace("Mała sypialnia", "pod łóżkiem");
            bathroom = new RoomWithHidingPlace("Łazienka", "prysznicu");

            frontYard = new OutsideWithDoor("Podwórko przed domem", false, "za głazem... tym większym");
            backYard = new OutsideWithDoor("Podwórko za domem", true, "w szopie" );
            garden = new Outside("Ogród", false);
            driveway = new OutsideWithHidingPlace("Podjazd", true, "garażu (jeśli nic akurat nie stoi)");


            livingRoom.Exits = new Location[] { diningRoom,stairs };
            kitchen.Exits = new Location[] { diningRoom };
            diningRoom.Exits = new Location[] { kitchen, livingRoom };
            frontYard.Exits = new Location[] { garden, backYard,driveway };
            backYard.Exits = new Location[] { frontYard, garden,driveway };
            garden.Exits = new Location[] { frontYard, backYard };
            stairs.Exits = new Location[] { livingRoom, hall };
            masterBedroom.Exits = new Location[] { hall, smallBedroom };
            smallBedroom.Exits = new Location[] { masterBedroom, hall };
            bathroom.Exits = new Location[] { hall };
            hall.Exits = new Location[] { masterBedroom, smallBedroom, bathroom, stairs };
            driveway.Exits = new Location[] { frontYard, backYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;

            ty = new Opponent(frontYard);


        }


        private void MoveToNewLocation(Location location)
        {
            currentLocation = location;

            exits.Items.Clear();

            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                exits.Items.Add(currentLocation.Exits[i].Name);
            }
            exits.SelectedIndex = 0;

            if (currentLocation is IHasExteriorDoor)
            {

                goThroughTheDoor.Visible = true;
                label1.Visible = true;



            }
            else
            {
                goThroughTheDoor.Visible = false;
                label1.Visible = false;
            }
            description.Text = currentLocation.Description;



        }
        private void newGameScreen()
        {
            exits.Visible = false;
            goThroughTheDoor.Visible = false;
            goHere.Visible = false;
            checkButton.Visible = false;
            label1.Visible = false;
            description.Font = new Font(description.Font.FontFamily, 20);
            description.Text = " Zwiedź dom i sprubuj mnie znaleźć.\r\n\r\n Liczę do 10\r\n\r\n Podejmiesz wyzwanie? ;)";

        }
        private void resetGame()
        {
            exits.Visible = false;
            goThroughTheDoor.Visible = false;
            goHere.Visible = false;
            checkButton.Visible = false;
            label1.Visible = false;
            IHidingPlace foundPlace = currentLocation as IHidingPlace;
            description.Font = new Font(description.Font.FontFamily, 20);
            description.Text = "Ukryłem się w "+foundPlace.HidingPlace+". Znalazłaś mnie w " +moves+" ruchach.\r\n\r\n Rewanżyk ???";
            button2.Visible = true;

        }
        private void redrawForm()
        {
           
            
            checkButton.Text = "Sprawdź " + currentLocation.Name+".";
        }


        private void goHere_Click(object sender, EventArgs e)
        {
            moves++;
            MoveToNewLocation(currentLocation.Exits[exits.SelectedIndex]);
            redrawForm();
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            moves++;
            if (currentLocation is IHasExteriorDoor)
            {
                IHasExteriorDoor currentDoor = currentLocation as IHasExteriorDoor;
                MoveToNewLocation(currentDoor.DoorLocation);
            }

        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            moves++; 
            if (ty.Check(currentLocation) == true)
            {
                description.Font = new Font(description.Font.FontFamily, 25);
                description.Text = "Tak tutaj się schowałem:)";
                Application.DoEvents();
                System.Threading.Thread.Sleep(1500);
                resetGame();

            }
            else
            {
                description.Font = new Font(description.Font.FontFamily, 20);
                description.Text = "Nie, tu mnie nie ma :p";
                Application.DoEvents();
                System.Threading.Thread.Sleep(1000);
                description.Font = new Font(description.Font.FontFamily, 11);
                description.Text = currentLocation.Description;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            description.Font = new Font(description.Font.FontFamily,25);
            button2.Visible = false;
            for (int i=1; i<10;i++)
            {
                ty.Move();
                description.Text = i + "...";
                Application.DoEvents();
                System.Threading.Thread.Sleep(600);
            }
            
            description.Text = "Znajdz mnie jeśli potrafisz :) !";
            Application.DoEvents();
            System.Threading.Thread.Sleep(1200);
            exits.Visible = true;
            goHere.Visible = true;
            checkButton.Visible = true;
            description.Font = new Font(description.Font.FontFamily, 11);
            MoveToNewLocation(livingRoom);
            
        }

       
    }
}