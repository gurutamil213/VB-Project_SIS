# Student Information System (SIS)

A **VB.NET Windows Forms Student Information System** for maintaining student records, academic information, document/proof references, and student searches.

The application uses **Microsoft Access (`.accdb`)** as its local database and provides a simple desktop interface for student record management.

## Features

- 🔐 Login screen
- 👨‍🎓 Add student records
- ✏️ Update existing student records
- 🗑️ Delete student records
- 🔎 Search students by Student ID
- 🔍 Filter/search students by:
  - Department
  - Academic year
  - Community
  - Gender
  - Combinations of the above filters
- 🖼️ Select and preview student/document images
- 📄 Store references to:
  - Student photo
  - 10th marksheet
  - 12th marksheet
  - 12th Transfer Certificate (TC)
  - Aadhaar
  - Passbook
  - Community certificate/document
- 👀 View stored student documents from the certificate/document viewer
- 📊 Display search results in a `DataGridView`
- 🆔 Automatically generate the next Student ID
- 🗃️ Local Microsoft Access database storage

## Technology Stack

| Technology | Details |
|---|---|
| Language | VB.NET |
| UI | Windows Forms |
| Framework | .NET Framework 4.0 |
| Platform | x86 / 32-bit |
| Database | Microsoft Access (`.accdb`) |
| Database Provider | Microsoft ACE OLE DB 12.0 |
| IDE | Visual Studio |

## Project Structure

```text
SIS/
├── App.config
├── Dashboard.vb
├── Dashboard.Designer.vb
├── Login_form.vb
├── Login_form.Designer.vb
├── entry.vb
├── entry.Designer.vb
├── find.vb
├── find.Designer.vb
├── proofs.vb
├── proofs.Designer.vb
├── Info_form.vb
├── Info_form.Designer.vb
├── sis.accdb
├── sisDataSet.xsd
├── sisDataSet.Designer.vb
├── My Project/
└── SIS.vbproj
```

### Main Forms

| Form | Purpose |
|---|---|
| `Login_form` | Authenticates the user before opening the application |
| `Dashboard` | Main application window and navigation menu |
| `entry` | Add, search, update, and delete student records |
| `find` | Filter and search student records |
| `proofs` | View student photo and document/proof images |
| `Info_form` | Displays project/developer information |

## Database

The project uses a Microsoft Access database:

```text
sis.accdb
```

The main table is:

```text
student
```

Important fields include:

| Field | Description |
|---|---|
| `sid` | Student ID |
| `sname` | Student name |
| `fname` | Father's name |
| `gender` | Gender |
| `dob` | Date of birth |
| `religion` | Religion |
| `community` | Community |
| `address` | Address |
| `phone` | Phone number |
| `email` | Email address |
| `department` | Department |
| `ayfrom` | Academic year start |
| `ayto` | Academic year end |
| `jd` | Joining date |
| `rollnum` | Roll number |
| `regnum` | Registration number |
| `photop` | Path to student photo |
| `10mp` | Path to 10th marksheet |
| `12mp` | Path to 12th marksheet |
| `12tcp` | Path to 12th TC |
| `aadharp` | Path to Aadhaar document |
| `passbookp` | Path to passbook document |
| `communityp` | Path to community document |

> **Important:** The document/image fields store **file paths**, not the image files themselves. If the referenced files are moved to another computer, the stored paths will no longer work.

## Requirements

Before building the project, make sure the development machine has:

- Windows
- Visual Studio with **VB.NET / .NET Framework desktop development** support
- .NET Framework 4.0 compatible development tools
- Microsoft Access Database Engine / ACE OLE DB provider
- A 32-bit/x86 compatible ACE OLE DB provider, because the project is configured for `x86`

The project uses:

```text
Provider=Microsoft.ACE.OLEDB.12.0
```

## Getting Started

### 1. Clone the repository

```bash
git clone https://github.com/<your-username>/<your-repository>.git
cd <your-repository>
```

### 2. Open the project

Open:

```text
SIS/SIS.vbproj
```

in Visual Studio.

### 3. Check the database

Make sure:

```text
SIS/sis.accdb
```

is present.

The project file is configured to copy the database to the output directory during the build.

### 4. Check the database connection

`App.config` contains a connection string using:

```text
|DataDirectory|\sis.accdb
```

However, some of the VB.NET forms currently create their own connection string with a machine-specific absolute path similar to:

```text
D:\VB-Project_SIS\sis.accdb
```

If you move the project to another computer, update these connection strings or, preferably, refactor the application so every form uses the connection string from `App.config`.

### 5. Build the project

The original project is configured for:

```text
Configuration: Debug / Release
Platform: x86
Target Framework: .NET Framework 4.0
```

Build the solution/project in Visual Studio and run the generated application.

## Application Flow

```text
Login
  │
  ▼
Dashboard
  ├── Entry
  │    ├── Add Student
  │    ├── Search by Student ID
  │    ├── Update Student
  │    ├── Delete Student
  │    └── Store Document Paths
  │
  ├── Find
  │    ├── Department
  │    ├── Academic Year
  │    ├── Community
  │    └── Gender
  │
  ├── Certificates
  │    └── View Student Documents
  │
  ├── Info
  │
  └── Exit
```

## Screens / Modules

### Login

The application starts with a login screen. Successful authentication opens the main dashboard.

### Student Entry

The Entry module manages student information such as:

- Personal details
- Contact information
- Department
- Academic year
- Joining date
- Roll number
- Registration number
- Student photograph
- Academic/document proofs

### Student Search

The Find module allows records to be filtered using different criteria and displays matching records in a table.

### Certificate / Document Viewer

The Certificates module allows a student to be selected and then displays the selected stored document/image.

## Important Security Notes

This project was originally created as a desktop/local application and contains a few things that should be improved before using it in production or publishing real student data.

### 1. Do not publish real student data

The repository contains an Access database file. If `sis.accdb` contains real student information, personal documents, phone numbers, addresses, or other private data, **do not commit that database to a public GitHub repository**.

For a public repository, consider:

- Removing real records from the database
- Creating a sanitized/demo database
- Adding the real database to `.gitignore`
- Keeping private data outside Git

### 2. Authentication should be improved

The current login implementation contains credentials directly in the VB.NET source code.

For a production application, replace this with:

- A database-backed user table
- Password hashing
- Role-based access control
- Secure configuration management

Do not expose actual credentials in the README or public source repository.

### 3. Avoid hard-coded database paths

Some forms currently use an absolute Windows path for the Access database. This makes the application dependent on the original developer's folder structure.

A better approach is to use the configured connection string from `App.config` throughout the application.

### 4. Use parameterized SQL queries

Some database operations currently build SQL queries by concatenating values directly into SQL strings.

For example, the project currently constructs `INSERT`, `UPDATE`, `DELETE`, and `SELECT` statements using textbox values.

For a more secure and reliable implementation, use parameterized `OleDbCommand` queries.

### 5. Validate uploaded file paths

The application stores paths to images/documents and later loads those files directly. Production code should validate that files exist and handle missing or invalid files gracefully.

## Known Limitations

- Windows desktop application only
- Requires the Microsoft ACE OLE DB provider
- Uses a local Microsoft Access database
- Configured for x86
- Document fields store file paths rather than document files
- Some database connection strings are hard-coded
- Authentication is currently hard-coded in the source
- SQL commands should be refactored to use parameters
- Error handling can be improved for database/file operations

## Possible Future Improvements

- [ ] Replace hard-coded authentication with secure user management
- [ ] Hash and securely store passwords
- [ ] Centralize the database connection string
- [ ] Replace string-concatenated SQL with parameterized queries
- [ ] Add proper exception handling and user-friendly error messages
- [ ] Add student record validation
- [ ] Store documents in a controlled application directory or secure document storage
- [ ] Add backup and restore functionality
- [ ] Add report generation
- [ ] Add export to Excel/PDF
- [ ] Add role-based permissions
- [ ] Modernize the UI
- [ ] Migrate from Access to SQL Server/MySQL/PostgreSQL for larger deployments
- [ ] Add automated tests

## Development Notes

The project uses generated Windows Forms designer files such as:

```text
*.Designer.vb
```

and generated dataset files such as:

```text
sisDataSet.Designer.vb
```

These files are normally maintained by Visual Studio and should generally be edited through the Windows Forms Designer/DataSet Designer rather than manually.

## License

No license file is currently included with the project.

If you plan to make this project open source, add a license such as MIT, Apache-2.0, or GPL-3.0 according to how you want others to use the code.

## Author

The project includes developer information in the application's Info screen.

If you are publishing this repository on GitHub, you can replace this section with your preferred GitHub profile/contact information.

---

**Note:** This README was prepared from the structure and source code of the supplied SIS project. Before publishing the repository, review the database, source code, configuration files, and document paths to ensure no private student information or credentials are exposed.

# Finally, If you want work with this file do this:

1. Download this entire file
2. Save it with folder on the excat path "D:\VB-Project_SIS"
3. Open Visual Studio 2010
4. Go to Open Project 
5. Open -> "D:\VB-Project_SIS\SIS\SIS.vbproj"
6. And just run it.
7. If there any issue contact me :)
