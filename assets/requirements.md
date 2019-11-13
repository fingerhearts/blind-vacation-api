# Blind Vacation Software Requirements
## Vision
Please also refer to Software Requirements - MVC for more information.  

We will build an API to support the functionality of the web app. When a user completes survey questions, based on the answers to each survey question, a destination is determined. The API retrieves the data from the database to get 1) the vacation destination with a summary description and photos, 2) 2 activities that are available to the destination, and 3) one lodging option of the destination.

---

## Scope(In/Out)
### In:
The API retrieves data from the database based on the user’s answers to the survey questions.
The API retrieves data from 3 data tables: destination, activities, and lodging.

### Out:
Refer to Software Requirements - MVC for details.

---

## MVP
At a minimum, the API will retrieve 3 sets of data from a local database, including data of a destination with a summary description, a photo of the destination, 2 activities, and one lodging option.

---

## Stretch Goals
* The web app proposes a search result using Hotels API from Google.

---

## Functional Requirements
* The /edit endpoint will send a survey result to the API via customized code. The API then determines which vacation plans match said code. A list of vacation plans containing a summary description, a photo of the destination, 2 activities, and one lodging option will be sent back to the /end via POST route.
* The /popular endpoint will send GET request to the API. The API sends back all of the pre-saved vacation plans containing a summary description, a photo of the destination, 2 activities, and one lodging option back to the /end via POST route.

---

## Non-Functional Requirements
* Availability - The API will be available at all times for the users to get trip results from the backend database through /popular and /survey pages. The user should be able to get trip results using APIs within 5 minutes if the user chooses to take a survey. 
* Maintainability - The API will be designed to optimize the ability of the future teams to revise or enhance with external APIs to expand the functionality

---

## Data Flow
This is a consolidation data flow of MVC and API.
### /Home
* When a user first enters  to our web app, the user sees the main page with images of multiple vacation destinations.
* On top of the page, a user can use the navigation bar to navigate through the web app.
* The navigation bar contains links to page /popular, /survey, and /myVacations.
### /myVacations
* When every time the user gets to this page, the user will be asked to enter his/her access key to access the user’s personal trip results. 
* Once the access key is entered and passed, the user sees all of his/her saved trip results. This page uses [GET] to get all the trip results data that match with the user’s access key from the front-end database.
### /survey
* The user takes 5 survey questions on this page. Once the user completes the survey, an answer code is compiled and is sent to /trip/update page.
* The user is then redirected to /trip/update page.
### /trip/update
* When the user is redirected to this page from /survey page, the /trip/update page uses [GET] to grab the answer code sent from /survey page in the URL.
* The function of the answer code is to grab the survey answers and compile the information into a code for the API to process.
* Then, this page uses [POST] to send over the answer code to the API and makes an API request to get the trip results from the backend database.
* The API converts the answer code to recommendation code that correlates to the backend database.
* Then the API uses recommendation code to get the corresponding data from the backend database and sends back the trip result data to the /trip/update page.
* The form on this /trip/update page will be auto filled with the trip result. The user can make modifications to it if he/she wants.
* On this page, the user can make modifications to the trip. If the user likes the trip, he/she can save the trip result otherwise the user can choose to retake the survey or go back to Home page.
* When the user saves the trip result, 1) this /trip/update page uses [POST] to send the modified trip result data to the front-end database, and 2) this /trip/update page uses [POST] to send the modified trip result and an updated answer code to the API.
* The API then converts the updated answer code to recommendation code that correlates to the data in the backend database.
* The API then sends the updated trip results to /trip/update form.
* Once the trip result is finalized and saved, the user is redirected to /myVacation page. After the user enters his/her access key, the user can view all of his/her saved trip results on this page.
* /myVacation page uses [GET] to get all of the saved trip results that match with the user’s access key. The results are shown on this page.
### /popular
* When user gets on this page, he/she can see all of the trip results that have been saved by all the other users from the mega database(the backend database).
* On this page, an API request is called to get all the saved vacation trip data using [GET] from the backend database.
* The API sends back all the data from backend database to this page.
