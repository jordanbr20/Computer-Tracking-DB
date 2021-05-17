
# ***Computer Tracking DB***
**Background**
Computer Tracking DB was one of my first major C# projects. As I have learned quite a bit since this development I will be updating this to be more robust over time and will be taking suggestions and keeping an eye on the issues tab. This was originally set-up for domain use, I have moved it over to use a username and password, please note that as I just put the password in the project I have not yet encrypted the passwords and all passwords will be plain text. This will be one of the first updates.

**Use**
Feel free to clone and use as you want, change anything you would like and make it up to your standards.

## Features
**Login System**
 - Uses username and password (As of now password is displayed as plain text)
 - Code for domain use is currently commented out.
 - Keeps track of all permissions.
 - If you are not marked as "active" in the database you will be denied access.

**Home Page**
 - Can be used to display anything text / image / webpage desired.
 - Landing page after logging in.

**Scan Machines**
 - Where machines can be scanned in or out of a certain location.
	-	will be updated to have the ability to select a location when scanning out.
 - Keeps track of machines going in and out of a main building / room by serial # and who.
 - Shows if the Scan failed or succeeded.
 - Can add notes to scanning a computer in or out.

**Inventory**
All inventory transactions will be shown in Computers_Transactions.

**New Inventory**
 - The ability to add new serials to the database.
 - Can lock model and location for quick adds using a barcode scan gun.
 - Will keep track of what tech added what serial / model / location added them to the database.
 - Shows if the Scan failed or succeeded.
 - Will not allow you to add duplicate serial numbers.

**Audit Inventory**
 - When audit mode is activated, you will not be able to manipulate computers with scan machines / new inventory / inventory move to ensure the best results of doing inventory.
 - Will provide what tech scanned it in to what location on what date.
 - Once the audit is completed you can export it to an CSV using the "Audit Export" button.
 - Shows if the Scan failed or succeeded.
 - Does not allow non-existing serials in database to be entered.
 - Will tell you if the serial was in the correct location.

**Move Inventory**
 - Allows you to move inventory between locations.
 - Will keep track of what tech moved an asset to what location on what date.
 - Can add notes on why a certain computer was moved.
 - Location can be locked for fast scanning.
 - Shows if the Scan failed or succeeded.

**Admin**
All admin settings are tracked in Admin_Transaction. It will note who changed what.

**Admin Technicians**
 - Ability to modify a techs permissions / Name / Password / Role / ect.
	- Please note that password is in plain text until updated.
 - Ability to add a technician.
 - Unchecking "Active" for a technician will no longer allow them to use Computer Tracking DB.

**Admin Models**
 - Ability to add new models to the database.
 - Ability to show model type. (Ex. Laptop / Desktop / ect)
 - Ability to make a model active or inactive.

**Admin locations**
 - Ability to add new locations.
 - Ability to make a location active or inactive.

**Admin Exports**
 - Will provide information from the database for the type of export.
 - Audit exports
 - Scan-Out by Date / Tech.
 - All transactions by Date / Tech.
 - Other exports
	- All computers and current status
	- All transactions by serial number.
	- Admin history.
** Admin Settings**
 - Audit
	- Toggle audit mode on or off.
 - Station
	- Change station password, this will be changed to work with Tech_Accounts in upcoming updates.
 - Dev
	- Impersonate another tech.
 - Email System
	- Change who is CCed on emails.
 - Database
	- Backup entire database.
	- Currently not setup.

**Print Labels**
 - Ability to print labels off for Serial / TechID / Location / model using Dymo printer.

**Email System**
 - Email system uses Outlook that is open in the background.
 - When a tech is added / modified it will send the tech an automated email with the permissions and information.
 - When adding new inventory an email can be sent using a button that will export all computers added and import them into the email along with automated message.
 
**Search**
- The searching tool will be displayed on every screen at the top.
- You can search by Tech / Username / Serial / Location
	- Tech / username
		- This will show everything that tech has scanned in or out / moved / audited / or added new inventory.
		- It will also display all permissions the user has at the bottom.
			- Please note the password is displayed in plain text, this will field will be removed completely in an update.

	 -	Serial
		 -	This will show the current location / last modified / model / and entered date at the top.
		 -	Below it will show all transactions this serial has been involved in.
	- location
		- Searching the location will display all computers currently in the searched location.
		- This will also display is the location is active or inactive at the top.
## Set-up
**Set-up will be coming shortly**

## Showcase

![Main](https://user-images.githubusercontent.com/30568107/118569234-82cd8480-b747-11eb-924c-2cf5b70048c9.gif)
![LoginSystem](https://user-images.githubusercontent.com/30568107/118569249-882acf00-b747-11eb-9fc9-8be763be9631.gif)
![ScanInOutSearch](https://user-images.githubusercontent.com/30568107/118569256-8cef8300-b747-11eb-88f4-989fbd92ce90.gif)
![Inventory](https://user-images.githubusercontent.com/30568107/118569259-8f51dd00-b747-11eb-95a6-b4033f3f96ee.gif)
![PrintLabels](https://user-images.githubusercontent.com/30568107/118569263-91b43700-b747-11eb-88d1-62e37b51f40c.gif)

