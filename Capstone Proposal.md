### Quin Asselin

### Inventory Tracker (Name Subject to Change)

### Project's Purpose:
This project is designed to provide a series of users with the ability to manipulate records for large product inventory using full CRUD. For the purposes of this application, it is assumed that users are working with various physical products along a chain of custody from intake and initial testing to shipment out of location internationally. Products are tracked internally on the database linked to this project. Users are able to use UI to create and edit various product listings to match a similar database of items publically available on eBay.

### The absolute Minimum Viable Product
* Allows uses to add product information (quantity, photos, location, pricing estimate, vendor/source, etc)
* Allows multiple users to access and edit the same database on different records at the same time
* End product is a desktop app compatible with Windows
* Product does not require microsoft office license
* Allows users to see previous sale (or sales) of database entries


### Technologies/Libraries/Frameworks/Modules etc
* C#
* SQL (migrating from SQLExpress)
* XAML
* .NET MAUI
* VirtualBox (VM Environment) for sandboxing old database
	* VBA
	* SQL
	* Microsoft Access
* Written on top of Windows 10 OS to for UserAuth
* WinUI (Possibly via MAUI)

### Additional Features (Stretch Goals)
* Use Window's UserAuth to verify activity of each account using program
* Present different base UI features to each user based on team role (Listing Creator, Reviewer, Photographer, Shipper)
* eBay API integration to cross-reference local and eBay Databases for errors and non-Matching Data
* Create statistics tab that allows users and supervisors to analyze sales data organized by lister, brand, etc
* Ability to filter entries by number of fields and locate by id
* predictive text for item locations to ensure uniformity

### Additional Technologies/APIs/Tools/Modules etc
* eBay Seller and/or Commerce API
* Active Directory security groups?
	* or Windows Authentication Access Group

### Additional Information for Instructors
* I did already discuss this with one of the Epicodus instructors, but to be clear I did get some unclear information from my manager when it came to producing a project like this. After my initial series of client interviews with Eric and Stephen (referenced in the research timeline) I began exploring alternative viable Capstone options. However, after feeling a bit lost in that search, my instructor was able to give me some excellent advice and I have since decided to carry on with working on my initially proposed project. I may or may not have spent an additional 10-15 minutes agonizing about which project to proceed with but this has been disincluded from the overall production timeline.