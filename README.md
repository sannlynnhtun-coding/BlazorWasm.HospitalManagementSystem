Icons 
https://bennymeg.github.io/ngx-fluent-ui/
https://master--628d031b55e942004ac95df1.chromatic.com/?path=/docs/icons-catalog--page

Dialog
https://www.fluentui-blazor.net/Dialog

```sql

truncate table public."Appointment" CASCADE;
truncate table public."Doctor" CASCADE;
truncate table public."DoctorSpecialList" CASCADE;

INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Cardiologist', 'Specializes in heart diseases and cardiovascular health.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Sicpholis', 'blah blah');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Cardiologist', 'Specializes in heart diseases and cardiovascular health.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Dermatologist', 'Focuses on skin, hair, and nail-related issues.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Gastroenterologist', 'Deals with the digestive system and its disorders.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Cardiologist', 'Specializes in heart diseases and cardiovascular health.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Neurologist', 'Specializes in the nervous system and its disorders.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Oncologist', 'Focuses on the diagnosis and treatment of cancer.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Orthopedist', 'Specializes in bones, joints, and musculoskeletal system.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Psychiatrist', 'Deals with mental health disorders and conditions.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Endocrinologist', 'Focuses on hormone-related disorders and endocrine system.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Ophthalmologist', 'Specializes in eye diseases and vision-related issues.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Pulmonologist', 'Deals with respiratory system disorders and lung diseases.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Urologist', 'Focuses on urinary tract disorders and male reproductive system.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Rheumatologist', 'Specializes in autoimmune diseases and musculoskeletal disorders.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Nephrologist', 'Deals with kidney diseases and renal system disorders.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Infectious Disease Specialist', 'Focuses on infectious diseases caused by bacteria, viruses, fungi, or parasites.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Allergist/Immunologist', 'Specializes in allergies, asthma, and immune system disorders.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Hematologist', 'Focuses on blood disorders and conditions.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Pediatrician', 'Specializes in the care of children, infants, and adolescents.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Geriatrician', 'Deals with health care of elderly patients and age-related conditions.');
INSERT INTO public."DoctorSpecialList" ("Name", "Description") VALUES ('Obstetrician/Gynecologist (OB/GYN)', 'Focuses on women''s reproductive health.');

INSERT INTO public."Doctor" ("DoctorName", "Email", "MobileNumber", "SpecialistId", "StartDuty", "EndDuty")
VALUES
('Dr. Emily Smith', 'emilysmith@example.com', '5551234567', 47, '09:00', '17:00'),
('Dr. Michael Johnson', 'michaeljohnson@example.com', '5552345678', 48, '10:00', '18:00'),
('Dr. Jessica Brown', 'jessicabrown@example.com', '5553456789', 49, '08:30', '16:30'),
('Dr. Christopher Davis', 'christopherdavis@example.com', '5554567890', 50, '07:00', '15:00'),
('Dr. Sarah Miller', 'sarahmiller@example.com', '5555678901', 51, '12:00', '20:00'),
('Dr. Matthew Wilson', 'matthewwilson@example.com', '5556789012', 52, '11:00', '19:00'),
('Dr. Ashley Garcia', 'ashleygarcia@example.com', '5557890123', 53, '08:00', '16:00'),
('Dr. Daniel Rodriguez', 'danielrodriguez@example.com', '5558901234', 54, '09:30', '17:30'),
('Dr. Elizabeth Martinez', 'elizabethmartinez@example.com', '5559012345', 55, '07:30', '15:30'),
('Dr. William Hernandez', 'williamhernandez@example.com', '5550123456', 56, '13:00', '21:00'),
('Dr. Olivia Lopez', 'olivialopez@example.com', '5551234567', 57, '08:00', '16:00'),
('Dr. Ethan Gonzalez', 'ethangonzalez@example.com', '5552345678', 58, '10:00', '18:00'),
('Dr. Mia Perez', 'miaperez@example.com', '5553456789', 59, '09:00', '17:00'),
('Dr. James Torres', 'jamestorres@example.com', '5554567890', 60, '08:30', '16:30'),
('Dr. Sophia Rivera', 'sophiarivera@example.com', '5555678901', 61, '11:00', '19:00'),
('Dr. Jacob Moore', 'jacobmoore@example.com', '5556789012', 62, '07:00', '15:00'),
('Dr. Emma King', 'emmaking@example.com', '5557890123', 63, '12:00', '20:00'),
('Dr. Benjamin Lee', 'benjaminlee@example.com', '5558901234', 64, '08:00', '16:00'),
('Dr. Mia Hill', 'miahill@example.com', '5559012345', 65, '09:30', '17:30'),
('Dr. Lucas Clark', 'lucasclark@example.com', '5550123456', 66, '07:30', '15:30'),
('Dr. Isabella Scott', 'isabellascott@example.com', '5551234567', 67, '13:00', '21:00'),
('Dr. Alexander Green', 'alexandergreen@example.com', '5552345678', 68, '08:00', '16:00'),
('Dr. Ava Adams', 'avaadams@example.com', '5553456789', 47, '10:00', '18:00'),
('Dr. Noah Baker', 'noahbaker@example.com', '5554567890', 48, '09:00', '17:00'),
('Dr. Grace Hall', 'gracehall@example.com', '5555678901', 49, '08:30', '16:30'),
('Dr. Samuel Young', 'samuelyoung@example.com', '5556789012', 50, '11:00', '19:00'),
('Dr. Lily Ward', 'lilyward@example.com', '5557890123', 51, '07:00', '15:00'),
('Dr. Logan Morgan', 'loganmorgan@example.com', '5558901234', 52, '12:00', '20:00'),
('Dr. Aiden Cooper', 'aidencooper@example.com', '5559012345', 53, '08:00', '16:00'),
('Dr. Zoey Coleman', 'zoeycoleman@example.com', '5550123456', 54, '09:30', '17:30'),
('Dr. Christopher Diaz', 'christopherdiaz@example.com', '5551234567', 55, '07:30', '15:30'),
('Dr. Natalie Richardson', 'natalierichardson@example.com', '5552345678', 56, '13:00', '21:00'),
('Dr. Leo Wood', 'leowood@example.com', '5553456789', 57, '08:00', '16:00'),
('Dr. Victoria Stewart', 'victoriastewart@example.com', '5554567890', 58, '10:00', '18:00'),
('Dr. Dylan Griffin', 'dylangriffin@example.com', '5555678901', 59, '09:00', '17:00'),
('Dr. Zoe Cooper', 'zoecooper@example.com', '5556789012', 60, '08:30', '16:30'),
('Dr. Gabriel Diaz', 'gabrieldiaz@example.com', '5557890123', 61, '11:00', '19:00'),
('Dr. Layla Richardson', 'laylarichardson@example.com', '5558901234', 62, '07:00', '15:00'),
('Dr. Nolan Hill', 'nolanhill@example.com', '5559012345', 63, '12:00', '20:00'),
('Dr. Penelope Young', 'penelopeyoung@example.com', '5550123456', 64, '08:00', '16:00'),
('Dr. Elijah Bell', 'elijahbell@example.com', '5551234567', 65, '09:30', '17:30'),
('Dr. Clara Baker', 'clarabaker@example.com', '5552345678', 66, '08:00', '16:00'),
('Dr. Grayson Perez', 'graysonperez@example.com', '5553456789', 67, '10:00', '18:00'),
('Dr. Ariana Hughes', 'arianahughes@example.com', '5554567890', 68, '09:00', '17:00'),
('Dr. Lincoln Turner', 'lincolnturner@example.com', '5555678901', 47, '08:30', '16:30'),
('Dr. Madelyn Cox', 'madelyncox@example.com', '5556789012', 48, '11:00', '19:00'),
('Dr. Oliver Ross', 'oliverross@example.com', '5557890123', 49, '07:00', '15:00'),
('Dr. Eva Ward', 'evaward@example.com', '5558901234', 50, '12:00', '20:00'),
('Dr. Xavier Brooks', 'xavierbrooks@example.com', '5559012345', 51, '08:00', '16:00'),
('Dr. Aurora Long', 'auroralong@example.com', '5550123456', 52, '09:30', '17:30'),
('Dr. Cameron Foster', 'cameronfoster@example.com', '5551234567', 53, '07:30', '15:30'),
('Dr. Hailey Powell', 'haileypowell@example.com', '5552345678', 54, '13:00', '21:00'),
('Dr. Jasper Russell', 'jasperrussell@example.com', '5553456789', 55, '08:00', '16:00'),
('Dr. Annabelle Price', 'annabelleprice@example.com', '5554567890', 56, '10:00', '18:00'),
('Dr. Tristan Hughes', 'tristanhughes@example.com', '5555678901', 57, '09:00', '17:00'),
('Dr. Lily Foster', 'lilyfoster@example.com', '5556789012', 58, '08:30', '16:30'),
('Dr. Elijah Shaw', 'elijahshaw@example.com', '5557890123', 59, '11:00', '19:00'),
('Dr. Stella Martinez', 'stellamartinez@example.com', '5558901234', 60, '07:00', '15:00'),
('Dr. Roman Nelson', 'romannelson@example.com', '5559012345', 61, '12:00', '20:00'),
('Dr. Ivy Brooks', 'ivybrooks@example.com', '5550123456', 62, '08:00', '16:00'),
('Dr. Alexander Rodriguez', 'alexanderrodriguez@example.com', '5551234567', 63, '09:30', '17:30'),
('Dr. Sofia Nguyen', 'sofianguyen@example.com', '5552345678', 64, '08:00', '16:00'),
('Dr. Ethan Carter', 'ethancarter@example.com', '5553456789', 65, '10:00', '18:00'),
('Dr. Maya Kim', 'mayakim@example.com', '5554567890', 66, '09:00', '17:00'),
('Dr. Liam Mitchell', 'liammitchell@example.com', '5555678901', 67, '08:30', '16:30'),
('Dr. Zoe Hall', 'zoehall@example.com', '5556789012', 68, '11:00', '19:00');





```

Chatgpt
Ask
```
INSERT INTO public."Doctor" ("DoctorName", "Email", "MobileNumber", "SpecialistId", "StartDuty", "EndDuty") VALUES ('Dr. John Doee', 'johnn.doe@example.com', '1234567890', 1, '08:00', '04:00');
pls generate real data and real time 100 rows (SpecialistId number range 47-68)
```

Result
```
INSERT INTO public."Doctor" ("DoctorName", "Email", "MobileNumber", "SpecialistId", "StartDuty", "EndDuty")
VALUES
('Dr. Emily Smith', 'emilysmith@example.com', '5551234567', 47, '09:00', '17:00'),
('Dr. Michael Johnson', 'michaeljohnson@example.com', '5552345678', 48, '10:00', '18:00'),
('Dr. Jessica Brown', 'jessicabrown@example.com', '5553456789', 49, '08:30', '16:30'),
('Dr. Christopher Davis', 'christopherdavis@example.com', '5554567890', 50, '07:00', '15:00'),
('Dr. Sarah Miller', 'sarahmiller@example.com', '5555678901', 51, '12:00', '20:00'),
('Dr. Matthew Wilson', 'matthewwilson@example.com', '5556789012', 52, '11:00', '19:00'),
('Dr. Ashley Garcia', 'ashleygarcia@example.com', '5557890123', 53, '08:00', '16:00'),
('Dr. Daniel Rodriguez', 'danielrodriguez@example.com', '5558901234', 54, '09:30', '17:30'),
('Dr. Elizabeth Martinez', 'elizabethmartinez@example.com', '5559012345', 55, '07:30', '15:30'),
('Dr. William Hernandez', 'williamhernandez@example.com', '5550123456', 56, '13:00', '21:00'),
('Dr. Olivia Lopez', 'olivialopez@example.com', '5551234567', 57, '08:00', '16:00'),
('Dr. Ethan Gonzalez', 'ethangonzalez@example.com', '5552345678', 58, '10:00', '18:00'),
('Dr. Mia Perez', 'miaperez@example.com', '5553456789', 59, '09:00', '17:00'),
('Dr. James Torres', 'jamestorres@example.com', '5554567890', 60, '08:30', '16:30'),
('Dr. Sophia Rivera', 'sophiarivera@example.com', '5555678901', 61, '11:00', '19:00'),
('Dr. Jacob Moore', 'jacobmoore@example.com', '5556789012', 62, '07:00', '15:00'),
('Dr. Emma King', 'emmaking@example.com', '5557890123', 63, '12:00', '20:00'),
('Dr. Benjamin Lee', 'benjaminlee@example.com', '5558901234', 64, '08:00', '16:00'),
('Dr. Mia Hill', 'miahill@example.com', '5559012345', 65, '09:30', '17:30'),
('Dr. Lucas Clark', 'lucasclark@example.com', '5550123456', 66, '07:30', '15:30'),
('Dr. Isabella Scott', 'isabellascott@example.com', '5551234567', 67, '13:00', '21:00'),
('Dr. Alexander Green', 'alexandergreen@example.com', '5552345678', 68, '08:00', '16:00'),
('Dr. Ava Adams', 'avaadams@example.com', '5553456789', 47, '10:00', '18:00'),
('Dr. Noah Baker', 'noahbaker@example.com', '5554567890', 48, '09:00', '17:00'),
('Dr. Grace Hall', 'gracehall@example.com', '5555678901', 49, '08:30', '16:30'),
('Dr. Samuel Young', 'samuelyoung@example.com', '5556789012', 50, '11:00', '19:00'),
('Dr. Lily Ward', 'lilyward@example.com', '5557890123', 51, '07:00', '15:00'),
('Dr. Logan Morgan', 'loganmorgan@example.com', '5558901234', 52, '12:00', '20:00'),
('Dr. Aiden Cooper', 'aidencooper@example.com', '5559012345', 53, '08:00', '16:00'),
('Dr. Zoey Coleman', 'zoeycoleman@example.com', '5550123456', 54, '09:30', '17:30'),
('Dr. Christopher Diaz', 'christopherdiaz@example.com', '5551234567', 55, '07:30', '15:30'),
('Dr. Natalie Richardson', 'natalierichardson@example.com', '5552345678', 56, '13:00', '21:00'),
('Dr. Leo Wood', 'leowood@example.com', '5553456789', 57, '08:00', '16:00'),
('Dr. Victoria Stewart', 'victoriastewart@example.com', '5554567890', 58, '10:00', '18:00'),
('Dr. Dylan Griffin', 'dylangriffin@example.com', '5555678901', 59, '09:00', '17:00'),
('Dr. Zoe Cooper', 'zoecooper@example.com', '5556789012', 60, '08:30', '16:30'),
('Dr. Gabriel Diaz', 'gabrieldiaz@example.com', '5557890123', 61, '11:00', '19:00'),
('Dr. Layla Richardson', 'laylarichardson@example.com', '5558901234', 62, '07:00', '15:00'),
('Dr. Nolan Hill', 'nolanhill@example.com', '5559012345', 63, '12:00', '20:00'),
('Dr. Penelope Young', 'penelopeyoung@example.com', '5550123456', 64, '08:00', '16:00'),
('Dr. Elijah Bell', 'elijahbell@example.com', '5551234567', 65, '09:30', '17:30'),
('Dr. Clara Baker', 'clarabaker@example.com', '5552345678', 66, '08:00', '16:00'),
('Dr. Grayson Perez', 'graysonperez@example.com', '5553456789', 67, '10:00', '18:00'),
('Dr. Ariana Hughes', 'arianahughes@example.com', '5554567890', 68, '09:00', '17:00'),
('Dr. Lincoln Turner', 'lincolnturner@example.com', '5555678901', 47, '08:30', '16:30'),
('Dr. Madelyn Cox', 'madelyncox@example.com', '5556789012', 48, '11:00', '19:00'),
('Dr. Oliver Ross', 'oliverross@example.com', '5557890123', 49, '07:00', '15:00'),
('Dr. Eva Ward', 'evaward@example.com', '5558901234', 50, '12:00', '20:00'),
('Dr. Xavier Brooks', 'xavierbrooks@example.com', '5559012345', 51, '08:00', '16:00'),
('Dr. Aurora Long', 'auroralong@example.com', '5550123456', 52, '09:30', '17:30'),
('Dr. Cameron Foster', 'cameronfoster@example.com', '5551234567', 53, '07:30', '15:30'),
('Dr. Hailey Powell', 'haileypowell@example.com', '5552345678', 54, '13:00', '21:00'),
('Dr. Jasper Russell', 'jasperrussell@example.com', '5553456789', 55, '08:00', '16:00'),
('Dr. Annabelle Price', 'annabelleprice@example.com', '5554567890', 56, '10:00', '18:00'),
('Dr. Tristan Hughes', 'tristanhughes@example.com', '5555678901', 57, '09:00', '17:00'),
('Dr. Lily Foster', 'lilyfoster@example.com', '5556789012', 58, '08:30', '16:30'),
('Dr. Elijah Shaw', 'elijahshaw@example.com', '5557890123', 59, '11:00', '19:00'),
('Dr. Stella Martinez', 'stellamartinez@example.com', '5558901234', 60, '07:00', '15:00'),
('Dr. Roman Nelson', 'romannelson@example.com', '5559012345', 61, '12:00', '20:00'),
('Dr. Ivy Brooks', 'ivybrooks@example.com', '5550123456', 62, '08:00', '16:00'),
('Dr. Alexander Rodriguez', 'alexanderrodriguez@example.com', '5551234567', 63, '09:30', '17:30'),
('Dr. Sofia Nguyen', 'sofianguyen@example.com', '5552345678', 64, '08:00', '16:00'),
('Dr. Ethan Carter', 'ethancarter@example.com', '5553456789', 65, '10:00', '18:00'),
('Dr. Maya Kim', 'mayakim@example.com', '5554567890', 66, '09:00', '17:00'),
('Dr. Liam Mitchell', 'liammitchell@example.com', '5555678901', 67, '08:30', '16:30'),
('Dr. Zoe Hall', 'zoehall@example.com', '5556789012', 68, '11:00', '19:00');
```

Ask
```
Cardiologist - Specializes in heart diseases and cardiovascular health.
Dermatologist - Focuses on skin, hair, and nail-related issues.
Gastroenterologist - Deals with the digestive system and its disorders.
Neurologist - Specializes in the nervous system and its disorders.
Oncologist - Focuses on the diagnosis and treatment of cancer.
Orthopedist - Specializes in bones, joints, and musculoskeletal system.
Psychiatrist - Deals with mental health disorders and conditions.
Endocrinologist - Focuses on hormone-related disorders and endocrine system.
Ophthalmologist - Specializes in eye diseases and vision-related issues.
Pulmonologist - Deals with respiratory system disorders and lung diseases.
Urologist - Focuses on urinary tract disorders and male reproductive system.
Rheumatologist - Specializes in autoimmune diseases and musculoskeletal disorders.
Nephrologist - Deals with kidney diseases and renal system disorders.
Infectious Disease Specialist - Focuses on infectious diseases caused by bacteria, viruses, fungi, or parasites.
Allergist/Immunologist - Specializes in allergies, asthma, and immune system disorders.
Hematologist - Focuses on blood disorders and conditions.
Pediatrician - Specializes in the care of children, infants, and adolescents.
Geriatrician - Deals with health care of elderly patients and age-related conditions.
Obstetrician/Gynecologist (OB/GYN) - Focuses on women's reproductive health.
Neonatologist - Specializes in the care of newborn infants, particularly those who are ill or premature.

pls split first - and covert json include name, description
```

Result
```
{
  "specialties": [
    {
      "name": "Cardiologist",
      "description": "Specializes in heart diseases and cardiovascular health."
    },
    {
      "name": "Dermatologist",
      "description": "Focuses on skin, hair, and nail-related issues."
    },
    {
      "name": "Gastroenterologist",
      "description": "Deals with the digestive system and its disorders."
    },
    {
      "name": "Neurologist",
      "description": "Specializes in the nervous system and its disorders."
    },
    {
      "name": "Oncologist",
      "description": "Focuses on the diagnosis and treatment of cancer."
    },
    {
      "name": "Orthopedist",
      "description": "Specializes in bones, joints, and musculoskeletal system."
    },
    {
      "name": "Psychiatrist",
      "description": "Deals with mental health disorders and conditions."
    },
    {
      "name": "Endocrinologist",
      "description": "Focuses on hormone-related disorders and endocrine system."
    },
    {
      "name": "Ophthalmologist",
      "description": "Specializes in eye diseases and vision-related issues."
    },
    {
      "name": "Pulmonologist",
      "description": "Deals with respiratory system disorders and lung diseases."
    },
    {
      "name": "Urologist",
      "description": "Focuses on urinary tract disorders and male reproductive system."
    },
    {
      "name": "Rheumatologist",
      "description": "Specializes in autoimmune diseases and musculoskeletal disorders."
    },
    {
      "name": "Nephrologist",
      "description": "Deals with kidney diseases and renal system disorders."
    },
    {
      "name": "Infectious Disease Specialist",
      "description": "Focuses on infectious diseases caused by bacteria, viruses, fungi, or parasites."
    },
    {
      "name": "Allergist/Immunologist",
      "description": "Specializes in allergies, asthma, and immune system disorders."
    },
    {
      "name": "Hematologist",
      "description": "Focuses on blood disorders and conditions."
    },
    {
      "name": "Pediatrician",
      "description": "Specializes in the care of children, infants, and adolescents."
    },
    {
      "name": "Geriatrician",
      "description": "Deals with health care of elderly patients and age-related conditions."
    },
    {
      "name": "Obstetrician/Gynecologist (OB/GYN)",
      "description": "Focuses on women's reproductive health."
    },
    {
      "name": "Neonatologist",
      "description": "Specializes in the care of newborn infants, particularly those who are ill or premature."
    }
  ]
}

```
