# FullNameCSharp

A simple **Full Name Form Application** developed in C# using Windows Forms and Visual Studio. The application combines a user's first name, middle initial, and last name into a single full-name output.

## Overview

FullNameCSharp provides a graphical form where users can enter their first name, middle initial, and last name. Clicking the full-name button combines the three values and displays the result in an output field.

The form also includes a clear function to reset the input and output fields and an exit function to close the application.

## Features

- **First-name input:** Accepts the user's first name.
- **Middle-initial input:** Accepts the user's middle initial.
- **Last-name input:** Accepts the user's last name.
- **Full-name generation:** Combines the three input fields into one string separated by spaces.
- **Clear function:** Clears all three input fields and the displayed full name.
- **Exit function:** Closes the form.
- **Windows Forms interface:** Uses a graphical desktop form rather than a console-based interface.

## Technologies Used

- C#
- .NET Windows Forms
- Visual Studio
- Event-driven programming

## Requirements

- Windows operating system
- Visual Studio with the .NET desktop development workload
- A compatible .NET Framework or .NET target supported by the complete project configuration

The repository does not specify a target framework in the available source files.

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/ichiroyamazaki/FullNameCSharp.git
cd FullNameCSharp
```

### 2. Open or create the Windows Forms project

The repository currently includes `FullNameTP.cs` and `README.md`. The source depends on Windows Forms designer-generated code and controls, including `InitializeComponent()`, `firstName`, `middleInitial`, `lastName`, and `outputName`.

To build the application, open the complete original Visual Studio project if available, including its project file and designer-generated files. If those files are unavailable, create a compatible Windows Forms project and restore the required form controls and event-handler connections.

### 3. Build and run

Once the complete project structure and form controls are available:

1. Open the project in Visual Studio.
2. Confirm that the form controls are named correctly.
3. Connect the buttons to their corresponding event handlers.
4. Build the project.
5. Run the application.

**Note:** The repository as currently listed may not build independently because the supporting project and designer files are not included.

## How to Use

1. Launch the Windows Forms application.
2. Enter a first name.
3. Enter a middle initial.
4. Enter a last name.
5. Click the full-name button to display the combined name.
6. Click the clear button to reset the form.
7. Click the exit button to close the application.

### Example

Input:

```text
First Name: Ichiro
Middle Initial: P.
Last Name: Yamazaki
```

Output:

```text
Ichiro P. Yamazaki
```

The output is formed by concatenating the contents of the three fields with spaces between them. The application does not independently validate or reformat the entered name components.

## Main Event Handlers

| Event handler | Purpose |
|---|---|
| `fullNameButton_Click` | Combines the first name, middle initial, and last name into the output field |
| `clearButton_Click` | Clears the input and output fields |
| `exitButton_Click` | Closes the current form |
| `TPonSoftwareDesignMidterm_Load` | Form-load event handler, currently containing no additional logic |

Additional text-change and label-click handlers are present but do not implement substantive behavior.

## Current Limitations

- The application does not validate empty or incorrectly formatted name fields.
- The full name is assembled exactly from the entered values, with spaces between fields.
- There is no database or file storage for user information.
- The application is designed as a simple desktop form.
- Supporting Windows Forms project and designer files are not included in the current repository listing.

## Purpose

This project demonstrates basic C# syntax, Windows Forms controls, event handlers, string concatenation, and simple desktop application interaction.

## Repository

[https://github.com/ichiroyamazaki/FullNameCSharp](https://github.com/ichiroyamazaki/FullNameCSharp)
