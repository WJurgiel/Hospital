# Central Hospital system
## Final project for database course
## Disclaimer: app works with local MySQL database, hosted locally.
### Database structure:
| Table name| Description |
|----------|----------|
| Doctors (lekarze)    | Contains personal and login details of every doctor      |
| Patients (pacjenci)    | Same as *doctors*, patient is assigned to the doctor based on patient's disease |
| Specializations (specjalizacje)    | Contains list of fields that doctors can specialize in|
| Medicaments (leki)    | List of miscellaneous medicaments with their producers      |
| Prescriptions (recepty)    | Every doctor can prescribe some medicament to their patients      |
| Opinions (opinie)    | Every patient can grade their doctor **ONCE**, anonymously or not      |
| Discharged (wypisani)    | Once you get on this hospital's database you always stay there |

![structure](image.png)

### Functionalities
* <p>Log in form - possible to log in as a doctor, patient, or administrator</p>

<table>
<tr>
    <td align="center">Doctor UI</td>
    <td align="center">Patient UI</td>
    <td align="center">Admin UI</td>
    
  </tr>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/0d423827-73c3-4598-9da8-f047747e3a29" alt="Doctor UI" width="300" /></td>
    <td><img src="https://github.com/user-attachments/assets/7270aaee-37eb-4d75-a319-9eb95d7dfe46" alt="Patient UI" width="300" /></td>
    <td><img src="https://github.com/user-attachments/assets/5ee97c08-1ade-4c2d-a577-ac5fc0eae285" alt="Admin UI" width="300" /></td>
  </tr>
</table>  

* adding new **doctor** or **patient** to the system as admin user  
 -add gif here-
 
