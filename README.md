# Municipal Services Application

The municipal services app is a Windows Forms desktop application designed to improve citizen engagement with local municipalities. 
It provides residents with a convenient way to report service delivery issues, stay informed about local events and track 
the progress of their service requests.


## Current Features

- **Navigation bar:**
    - A side navigation menu that is visible on every page, providing quick access to all features on the app (used in favour of main menu for visibility)
    
- **Report Service Related Issues:**
    - Enter location of issue
    - Select a category (area of concern) for the issue
    - Write detailed description for context
    - Attach supporting documents (media files like images) using a file dialog
    - Submit issues
    - Pop up alert of a summary of the issue after it is submitted
 
- **View and FIlter Events & Announcements:**
    - View local events and announcements with the following details: name, category, date, description
    - Filter events by date:
        - Users can find events within a certain date range by selecting a "start" date and an "end" date
        - Events within the date range are displayed in chronological order
    - Filter events by category:
        - User can select a category
        - Events within the category are displayed
        
- **Event Recommendations by Category:**
    - User search history is tracked and three recommendations are made based on
        - Firstly, their most recent search, then their most frequently searched categories
    - Only one event (one with the nearest date) per category is displayed to the user
    - 
- **Service Request Status:**
    - View list of all submitted service requests sorted by urgency
    - View list of all submitted service requests
    - Track service requests unique identifiers
        - Search for a request by its unique ID by entiering the number and clicking the search button
          
- **Feedback and Reviews:**
    - User engagement strategy allowing users to submit feedback and suggestions
    - Feedback on the Municipal Services app:
        - Rate experience from 1-3 (1 being poor, 3 being excellent)
        - Give written review or suggestions on the app
    - Feedback on service delivery performance:
        - Rate service delivery experience from 1-3 (1 being poor, 3 being excellent)
        - Give written review or suggestions for improvement
    
- **Help Section:**
    - Explanation of application features
    - Tutorial in the form of step-by-step instructions

---

## Prerequisites:
- **Operating System:** Windows 10 or later
- **Development Environment:** Visual Studio Community 2022
- **.NET Framework:** 4.8


## Installation & Execution:
1. Clone this repository  
2. Open the project by opening the solution file (.sln) in Visual Studio 
3. Build the project by clicking "Build", then "Build Solution" or F7
4. Run the application by pressing the "Start" button
Or simply download it by clicking the green `Code` button to download the project zip folder, unzip it and open in Visual Studio.

---

## Demonstration Video & POE Document

| Submission        | Video Presentation         | 
|------------------------|------------------------|
| Part 1 | [Part 1 Video Presentation](https://youtu.be/ybmTW8jIpIU?si=X9f4BJmVwwJBKtZc) 
| Part 2 | [Part 2 Video Presentation](https://youtu.be/vc871rVtu4Q) |
| Final ✨ | [Final Video Presentation](https://youtu.be/UVL2O7MCpfE) | 

---

# CHANGELOG

## v3.0 - 12/11/2025
### Added
- Implemented the Service request status page to track the progress of service requests
- Integrated heaps for prioritising service requests based on urgency
- Integrated Binary Search Tree for efficient search and organisation

### Improved
- Improved recommendation feature to suggest "related" events instead of similar events

## v2.0 - 15/10/2025
### Added
- Implimented the Events and Announcements feature
- Used dictionaries for quick event lookups, hash sets to prevent duplication and stacks to track users' searches
- Implimented event recommendation logic to suggest top three search categories

### Improved
- Changed service request report to store in Queue instead of list


## v1.0 - 10/08/2025
### Added
- Created Service Request Reporting feature using a List
- Implemented feedback submission as user engagement feature
