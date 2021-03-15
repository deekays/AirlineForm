/* Program ID: SDraper_Assignment1
 * 
 * Purpose: Create a small form that allows users to book themselves on a plane
 * 
 * History:
 *      created by Stephen Draper, June 2020
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineReservation
{
    public partial class AirForm : Form
    {
        RadioButton selectedSeat = null; // important that we define this here, so that each method/click event has access to it.
        string[,] filledSeatsNames = new string[5, 4];
        string[] waitingList = new string[10];
        int waitingListCounter = 0;

        public AirForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Pulls which radio button is clicked within the group box, allows us to use it throughout the rest of the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Seat_Click(object sender, EventArgs e)
        {
            selectedSeat = sender as RadioButton;
        }

        /// <summary>
        /// Event happens when user selects 'Book'. Verifies that the user has entered correct information and then detects which button they have selected, the corresponding
        /// position within the array, and writes the entered name to that position and turns the selected seat red to indicate that it is taken.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBook_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtName.Text)) // forces user to enter a name
            {
                if(selectedSeat != null) // forces user to select a seat
                {
                    if (selectedSeat.BackColor != Color.Red) // since the background will be red if the seat is occupied, we can use this to ensure that it is empty
                    {
                        selectedSeat.BackColor = Color.Red;
                        
                        // I had previously used the below (commented out) method to check the selected button's position via taking a substring out of the name, 
                        // running it through a switch to change the leters to fitting numbers, and assign accordingly within the array. 
                        // After learning about Tags in class I felt that method would be more efficient and allow for more dynamic naming.

                        //int col = seatColCheck(selectedSeat.Name.Substring(3, 1)); // checks the column by passing the fourth letter of the name of the radio box through our switch that returns the numerical position
                        //int row = (int.Parse(selectedSeat.Name.Substring(4, 1))-1); // checks the row by simply seeing the fifth letter and subtracting one

                        string temp = selectedSeat.Tag.ToString(); // grabs the seat's tag and tosses it into a string for easier use
                        int row = int.Parse(temp.Substring(0, 1)); // takes the first character of the tag, which I have named to match the position in the array, parses it, and assigns it to the row
                        int col = int.Parse(temp.Substring(1, 1)); // takes the second character of the tag and assigns it to the column

                        filledSeatsNames[row, col] = txtName.Text; // populates our 'filledSeatsNames' array with the currently submitted name


                        lblOutput.Text = $"Seat {selectedSeat.Name.Substring(3, 2)} has been booked by {txtName.Text}.";
                        txtName.Text = string.Empty; // empties name field
                        selectedSeat.Checked = false; // unselects selected seat visually
                        selectedSeat = null; // unselects selected seat on program side
                    }
                    else
                    {
                        lblOutput.Text = "That seat has already been chosen, please choose a different seat.";
                    }
                }
                else
                {
                    lblOutput.Text = "Please select a seat to book.";
                }
 
            }
            else
            {
                lblOutput.Text = "Please enter a name for your booking.";
            }    
        }

        /*
        /// <summary>
        /// This method was used to take the portion of the seat name that was in letter form, and convert it to an integer that represented its position within the array.
        /// It was removed in favour of using tags to hold the placement instead.
        /// </summary>
        /// <param name="col">'col' is the fourth character of the radio button name, taken out with substring above</param>
        /// <returns>Returns the desired position within the array, denoted by the letter converted to numeric</returns>
        private int seatColCheck (string col)
        {
            int output = 5;
            switch(col)
            {
                case "A":
                    output = 0;
                    break;
                case "B":
                    output = 1;
                    break;
                case "C":
                    output = 2;
                    break;
                case "D":
                    output = 3;
                    break;
                default:
                    output = 5;
                    break;
            }
            return output;
        }*/


        /// <summary>
        /// This event populates the txtAllSeats window with the names and locations of every passenger currently booked. It checks if each position within the array is empty, 
        /// and if it isn't, then it outputs the name within that position, and then outputs the seat name by running the column number through a basic switch to obtain a  
        /// corresponding letter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAllSeats_Click(object sender, EventArgs e)
        {
            txtAllSeats.Text = string.Empty; // empties the text box in case it has been previously used. We don't need any information stored within this box.
            string seatCol = "";

            for (int row = 0; row < filledSeatsNames.GetLength(0); row++) // step through first dimension of array
            {
                for(int col = 0; col < filledSeatsNames.GetLength(1); col++) // step through second demension
                {
                    if(!String.IsNullOrEmpty(filledSeatsNames[row,col])) // checks that the position within the array is not empty
                    {
                        switch(col) // converts the column from an integer to a corresponding seat letter
                        {
                            case 0:
                                seatCol = "A";
                                break;
                            case 1:
                                seatCol = "B";
                                break;
                            case 2:
                                seatCol = "C";
                                break;
                            case 3:
                                seatCol = "D";
                                break;
                            default:
                                seatCol = "";
                                break;
                        }
                        txtAllSeats.Text += $"{seatCol}{row+1} - {filledSeatsNames[row, col]}{Environment.NewLine}"; // outputs their seat position and their name
                    }
                }
            }
        }

        /// <summary>
        /// This click event will occur upon the user clicking 'Cancel'. It detects which seat they have selected and removes that person from the filledSeatsNames array.
        /// It also returns the selected seat to the default colour.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(selectedSeat != null) // ensures they have selected a seat
            {
                // As above, the commented out method was one I used previously to determine seat position within array, based on the radio button's name.
                // This was replaced by using the tag to hold the array position, which I feel is a cleaner method for our purpose here.
                
                //int col = seatColCheck(selectedSeat.Name.Substring(3, 1)); // checks the column by passing the fourth letter of the name of the radio box through our switch that returns the numerical position
                //int row = (int.Parse(selectedSeat.Name.Substring(4, 1)) - 1); // checks the row by simply seeing the fifth letter and subtracting one

                string temp = selectedSeat.Tag.ToString(); // grabs the seat's tag and tosses it into a string for easier use
                int row = int.Parse(temp.Substring(0, 1)); // takes the first character of the tag, which I have named to match the position in the array, parses it, and assigns it to the row
                int col = int.Parse(temp.Substring(1, 1)); // takes the second character of the tag and assigns it to the column
                filledSeatsNames[row, col] = String.Empty; // empties the seat that has been selected
                lblOutput.Text = $"Seat {selectedSeat.Name.Substring(3, 2)} has been emptied.";
                selectedSeat.BackColor = default(Color); // apparently forms create their own colour upon generation, this returns it back to the default selector
                selectedSeat.UseVisualStyleBackColor = true; // however, the above line won't work until we do this, because the colour generation is turned off when we forced it to be red.
                                                             // This turns back on the auto-detect and allows the 'default' that we assigned above, to once again be the correct colour rather than white.
                selectedSeat.Checked = false; // deselects the seat visually
                selectedSeat = null; // deselects the seat program-side
                
                
            }
            else
            {
                lblOutput.Text = "Please select a seat to remove booking from.";
            }
        }

        /// <summary>
        /// This click event occurs when the user clicks 'Fill All Seats'. It will go through and check which seats are empty, and fill them with fake names. It is intentional that it
        /// skips the seats that were previously filled, as it seemed silly that someone debugging would have to recreate the database afterwards. It also sets all seats to red, in 
        /// accordance with the seat filling events above.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFillAll_Click(object sender, EventArgs e)
        {
            string[] fillAllSeats = {"Fake 1", "Fake 2", "Fake 3", "Fake 4", "Fake 5", "Fake 6", "Fake 7", "Fake 8", "Fake 9", 
                "Fake 10", "Fake 11", "Fake 12", "Fake 13", "Fake 14", "Fake 15", "Fake 16", "Fake 17", "Fake 18", "Fake 19", "Fake 20"}; // an array full of 'names' to populate the seats
            int counter = 0;
            for(int row = 0; row<filledSeatsNames.GetLength(0);row++)
            {
                for(int col = 0; col<filledSeatsNames.GetLength(1);col++)
                {
                    if(string.IsNullOrEmpty(filledSeatsNames[row,col])) // I decided to leave previously filled seats alone, I felt it would be easier to debug if you didn't lose all previous passengers
                    {
                        filledSeatsNames[row, col] = fillAllSeats[counter++]; // fills any empty seat with the fake names above
                    }
                }
            }
            foreach (var button in grbSeats.Controls.OfType<RadioButton>()) // targets each radio button within grbSeats
            {
                button.BackColor = Color.Red; // turns them all red - no need to skip the previously red ones, they all end up red anyway.
            }
        }

        /// <summary>
        /// Event occurs when user clicks 'Add to Waiting List'. It checks if the entire two dimensional array filledSeatsNames is full, and if it is, allows user to add
        /// their name to the waitingList array.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWaitingList_Click(object sender, EventArgs e)
        {
            bool full = true; // full = true until it finds a seat that is empty
            for(int row = 0; row<filledSeatsNames.GetLength(0);row++)
            {
                for(int col = 0; col<filledSeatsNames.GetLength(1);col++)
                {
                    if(string.IsNullOrEmpty(filledSeatsNames[row,col])) // will skip this until it finds an element of the filledSeatsNames array that is empty
                    {
                        full = false; // if it finds any empty elements within the array, it sets full to false
                    }
                }
            }
            
            if(full == true) // if the plane is full, continue
            {
                if(!string.IsNullOrEmpty(txtName.Text)) // forces the user to enter a name
                {
                    if (waitingListCounter != 10) // the maximum waiting list size is 10 because it seemed like a good length
                    {
                        waitingList[waitingListCounter] = txtName.Text; // adds their name to the waitingList array
                        waitingListCounter++; // simply keeps track of how many are in the list. .length doesn't work because the array is a set lenght of 10 naturally.
                        lblOutput.Text = $"{txtName.Text} has been added to the waiting list, in position {waitingListCounter}.";
                        txtName.Text = string.Empty; // empties text field
                    }
                    else
                    {
                        lblOutput.Text = "We're sorry, the waiting list is full.";
                    }
                }
                else
                {
                    lblOutput.Text = "Please enter a name before adding to the waiting list.";
                }
            }
            else
            {
                lblOutput.Text = "The waiting list cannot be added to until all seats are filled.";
            }
        }

        /// <summary>
        /// Event occurs when user clicks 'Show Waiting List'. Simply clears the txtShowWaitingList box and outputs the WaitingList array once more.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowWaitingList_Click(object sender, EventArgs e)
        {
            txtShowWaitingList.Text = string.Empty; // empties txtShowWaitingList from previous clicks
            for(int i = 0; i<waitingList.Length; i++)
            {
                if(!string.IsNullOrEmpty(waitingList[i])) // since the waiting list retained its length of 10, it was outputting empty blocks below the proper list. 
                                                          // in our current code this is irrelivant, but with a larger scope it would create a scroll bar and potentially
                                                          // cause problems down the line. So we simply added this if statement to only output if that block had content. 
                {
                    txtShowWaitingList.Text += $"{waitingList[i]}{Environment.NewLine}"; // outputs the waiting list
                }
            }
        }
    }
}