# OrderTracker
To run the source code you must open the solution in and IDE such as Visual Studio 2019.
Once the solution is open the program should compile with no errors.

As far as input parameters are concerned any text box should allow alphanumeric characters while only dates can be used in
the date/time boxes.

Users are authenticated in the drop down at the top for user. On a business network this would pull from a user profile.

At a minimum the user needs to enter a customer name to enter a quote. Past that fields will not be required to save to the database.

Form1.vb - This is the main portion of the program. This is what controls all of the grids, tabs, text boxes, combo boxes, and buttons
in the program.

LogDate.vb - This is a class that handles the User logging their initials and dates into the program.

Schedule.vb - This is a class that handles the back scheduling for orders. Once a delivery date is picked and the user clicks for back
scheduling this class handles the dates.

Search.vb - This is a class used for allowing the user to search through the customer records on the Main tab.

Datasets:
QuoteOrders - This dataset is used for the datagrid on the Main tab of the program. This dataset contains the most valuable information needed
in a small area.

QuoteReport - This dataset is used to populate the datagrid on the Quote Report tab with the priority on which quotes needed to be completed.

OrderReport - This dataset is used to populate the datagrid on the Order Report tab with the priority on which Order needs to be completed next in the
process to ship out the door and deliver on time.
