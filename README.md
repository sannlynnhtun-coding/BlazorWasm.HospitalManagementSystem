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

INSERT INTO public."Patient" ("Name", "Gender", "PhoneNumber", "Email", "BloodType", "BirthDate", "Address")
VALUES
('Emma Johnson', 'F', '5551112222', 'emma.johnson@example.com', 'A+', '1990-05-15', '123 Maple Street'),
('Liam Smith', 'M', '5552223333', 'liam.smith@example.com', 'O-', '1985-09-22', '456 Oak Avenue'),
('Olivia Brown', 'F', '5553334444', 'olivia.brown@example.com', 'B+', '1992-11-03', '789 Elm Road'),
('Noah Davis', 'M', '5554445555', 'noah.davis@example.com', 'AB-', '1994-07-18', '1010 Pine Lane'),
('Ava Wilson', 'F', '5555556666', 'ava.wilson@example.com', 'A-', '1988-03-30', '1313 Cedar Court'),
('Isabella Taylor', 'F', '5556667777', 'isabella.taylor@example.com', 'O+', '1996-02-08', '1515 Birch Street'),
('Mason Martinez', 'M', '5557778888', 'mason.martinez@example.com', 'B-', '1998-12-12', '1717 Willow Avenue'),
('Sophia Anderson', 'F', '5558889999', 'sophia.anderson@example.com', 'AB+', '1993-06-25', '1919 Maple Road'),
('Logan Thomas', 'M', '5559990000', 'logan.thomas@example.com', 'A-', '1991-08-04', '2020 Oak Lane'),
('Ella Hernandez', 'F', '5550001111', 'ella.hernandez@example.com', 'O+', '1997-04-09', '2222 Elm Street'),
('Oliver Nelson', 'M', '5551112222', 'oliver.nelson@example.com', 'A+', '1989-10-12', '2424 Pine Avenue'),
('Charlotte White', 'F', '5552223333', 'charlotte.white@example.com', 'B+', '1995-01-28', '2626 Cedar Road'),
('William Adams', 'M', '5553334444', 'william.adams@example.com', 'AB-', '1999-09-01', '2828 Birch Lane'),
('Amelia Rodriguez', 'F', '5554445555', 'amelia.rodriguez@example.com', 'A-', '1990-07-15', '3030 Willow Street'),
('Ethan Garcia', 'M', '5555556666', 'ethan.garcia@example.com', 'O+', '1992-05-20', '3232 Maple Avenue'),
('Avery Martinez', 'F', '5556667777', 'avery.martinez@example.com', 'B-', '1998-11-24', '3434 Oak Lane'),
('Benjamin Scott', 'M', '5557778888', 'benjamin.scott@example.com', 'AB+', '1994-03-17', '3636 Pine Road'),
('Mia Clark', 'F', '5558889999', 'mia.clark@example.com', 'A-', '1996-08-07', '3838 Cedar Street'),
('Alexander Hall', 'M', '5559990000', 'alexander.hall@example.com', 'O-', '1993-12-30', '4040 Willow Avenue'),
('Harper Adams', 'F', '5550001111', 'harper.adams@example.com', 'B+', '1997-01-14', '4242 Birch Lane'),
('James Baker', 'M', '5551112222', 'james.baker@example.com', 'AB-', '1991-06-28', '4444 Elm Road'),
('Evelyn Gonzalez', 'F', '5552223333', 'evelyn.gonzalez@example.com', 'A+', '1987-09-09', '4646 Oak Street'),
('Michael Turner', 'M', '5553334444', 'michael.turner@example.com', 'O+', '1995-02-03', '4848 Pine Avenue'),
('Ella Lee', 'F', '5554445555', 'ella.lee@example.com', 'B-', '1999-05-26', '5050 Cedar Road'),
('Lucas Wright', 'M', '5555556666', 'lucas.wright@example.com', 'AB+', '1992-10-19', '5252 Willow Street'),
('Scarlett King', 'F', '5556667777', 'scarlett.king@example.com', 'A-', '1998-07-23', '5454 Birch Lane'),
('Jack Harris', 'M', '5557778888', 'jack.harris@example.com', 'O-', '1990-04-12', '5656 Elm Avenue'),
('Grace Campbell', 'F', '5558889999', 'grace.campbell@example.com', 'B+', '1996-11-06', '5858 Oak Road'),
('Henry Young', 'M', '5559990000', 'henry.young@example.com', 'AB-', '1993-08-30', '6060 Pine Street'),
('Madison Flores', 'F', '5550001111', 'madison.flores@example.com', 'A+', '1988-12-13', '6262 Cedar Lane'),
('Jackson Lewis', 'M', '5551112222', 'jackson.lewis@example.com', 'O+', '1994-02-26', '6464 Willow Avenue'),
('Aria Martinez', 'F', '5552223333', 'aria.martinez@example.com', 'B-', '1991-05-10', '6666 Birch Road'),
('Elijah Hill', 'M', '5553334444', 'elijah.hill@example.com', 'AB+', '1997-09-03', '6868 Elm Street'),
('Aurora Thompson', 'F', '5554445555', 'aurora.thompson@example.com', 'A-', '1995-03-18', '7070 Oak Avenue'),
('Carter Walker', 'M', '5555556666', 'carter.walker@example.com', 'O-', '1989-07-21', '7272 Pine Road'),
('Violet Perez', 'F', '5556667777', 'violet.perez@example.com', 'B+', '1992-12-04', '7474 Cedar Street'),
('Leo Cooper', 'M', '5557778888', 'leo.cooper@example.com', 'AB-', '1998-06-17', '7676 Willow Lane'),
('Penelope Mitchell', 'F', '5558889999', 'penelope.mitchell@example.com', 'A+', '1993-11-30', '7878 Birch Avenue'),
('Wyatt Carter', 'M', '5559990000', 'wyatt.carter@example.com', 'O+', '1990-04-14', '8080 Elm Road'),
('Eleanor Foster', 'F', '5550001111', 'eleanor.foster@example.com', 'B-', '1996-08-27', '8282 Oak Lane'),
('Luke Sanchez', 'M', '5551112222', 'luke.sanchez@example.com', 'AB+', '1999-01-10', '8484 Pine Street'),
('Hannah Ross', 'F', '5552223333', 'hannah.ross@example.com', 'A-', '1994-05-23', '8686 Cedar Road'),
('Gabriel Morris', 'M', '5553334444', 'gabriel.morris@example.com', 'O-', '1988-09-06', '8888 Willow Street'),
('Evelyn Rivera', 'F', '5554445555', 'evelyn.rivera@example.com', 'B+', '1995-02-19', '9090 Birch Avenue'),
('Christopher Bell', 'M', '5555556666', 'christopher.bell@example.com', 'AB-', '1991-06-02', '9292 Elm Lane'),
('Savannah Woods', 'F', '5556667777', 'savannah.woods@example.com', 'A+', '1997-10-15', '9494 Oak Road'),
('Jonathan Ward', 'M', '5557778888', 'jonathan.ward@example.com', 'O+', '1992-04-28', '9696 Pine Street'),
('Addison Powell', 'F', '5558889999', 'addison.powell@example.com', 'B-', '1998-12-11', '9898 Cedar Avenue'),
('David Perry', 'M', '5559990000', 'david.perry@example.com', 'AB+', '1993-07-24', '123 Hillside Drive'),
('Chloe Long', 'F', '5550001111', 'chloe.long@example.com', 'A-', '1989-11-07', '456 Valley Road'),
('Jaxon Butler', 'M', '5551112222', 'jaxon.butler@example.com', 'O+', '1995-03-20', '789 Mountain Lane'),
('Natalie Barnes', 'F', '5552223333', 'natalie.barnes@example.com', 'B+', '1991-08-02', '101 Oakwood Avenue'),
('Gabriel Howard', 'M', '5553334444', 'gabriel.howard@example.com', 'AB-', '1997-12-15', '202 Forest Drive'),
('Zoe Coleman', 'F', '5554445555', 'zoe.coleman@example.com', 'A+', '1992-06-28', '303 Brookside Lane'),
('Anthony Patterson', 'M', '5555556666', 'anthony.patterson@example.com', 'O-', '1998-10-11', '404 River Street'),
('Audrey Simmons', 'F', '5556667777', 'audrey.simmons@example.com', 'B-', '1994-02-24', '505 Lakeview Drive'),
('Dominic Simmons', 'M', '5557778888', 'dominic.simmons@example.com', 'AB+', '1990-07-08', '606 Meadow Lane'),
('Maya Price', 'F', '5558889999', 'maya.price@example.com', 'A-', '1996-11-21', '707 Pinecrest Avenue'),
('Nathan Howard', 'M', '5559990000', 'nathan.howard@example.com', 'O+', '1991-05-04', '808 Cherry Lane'),
('Sofia Webb', 'F', '5550001111', 'sofia.webb@example.com', 'B+', '1997-09-17', '909 Elm Street'),
('Caleb Owens', 'M', '5551112222', 'caleb.owens@example.com', 'AB-', '1993-01-30', '1010 Forest Avenue'),
('Zoey Elliott', 'F', '5552223333', 'zoey.elliott@example.com', 'A+', '1988-06-12', '1111 Maple Drive'),
('Joseph Hopkins', 'M', '5553334444', 'joseph.hopkins@example.com', 'O-', '1994-10-25', '1212 Pine Lane'),
('Madison Wallace', 'F', '5554445555', 'madison.wallace@example.com', 'B-', '1999-04-08', '1313 Willow Road'),
('Aaron Hart', 'M', '5555556666', 'aaron.hart@example.com', 'AB+', '1992-08-21', '1414 Birch Lane'),
('Aubrey Woods', 'F', '5556667777', 'aubrey.woods@example.com', 'A-', '1998-12-04', '1515 Cedar Street'),
('Thomas Hunt', 'M', '5557778888', 'thomas.hunt@example.com', 'O+', '1993-03-17', '1616 Elm Avenue'),
('Brooklyn Foster', 'F', '5558889999', 'brooklyn.foster@example.com', 'B+', '1990-07-30', '1717 Oak Road'),
('Eli Cole', 'M', '5559990000', 'eli.cole@example.com', 'AB-', '1996-11-12', '1818 Pine Street'),
('Aaliyah Morgan', 'F', '5550001111', 'aaliyah.morgan@example.com', 'A+', '1991-05-03', '1920 Maple Lane'),
('Evan Andrews', 'M', '5551112222', 'evan.andrews@example.com', 'O-', '1997-09-16', '2020 Cedar Avenue'),
('Lillian Fisher', 'F', '5552223333', 'lillian.fisher@example.com', 'B-', '1993-02-28', '2121 Elm Street'),
('Alexander Fisher', 'M', '5553334444', 'alexander.fisher@example.com', 'AB+', '1988-07-13', '2222 Oak Lane'),
('Addison Harrison', 'F', '5554445555', 'addison.harrison@example.com', 'A-', '1995-11-26', '2323 Pine Road'),
('David Daniels', 'M', '5555556666', 'david.daniels@example.com', 'O+', '1990-04-09', '2424 Cedar Avenue'),
('Leah Gordon', 'F', '5556667777', 'leah.gordon@example.com', 'B+', '1996-08-22', '2525 Willow Lane'),
('Joseph Garcia', 'M', '5557778888', 'joseph.garcia@example.com', 'AB-', '1992-01-05', '2626 Birch Street'),
('Lucy Burns', 'F', '5558889999', 'lucy.burns@example.com', 'A+', '1998-05-18', '2727 Elm Road'),
('Connor Hernandez', 'M', '5559990000', 'connor.hernandez@example.com', 'O-', '1993-10-31', '2828 Oak Avenue'),
('Sarah Hayes', 'F', '5550001111', 'sarah.hayes@example.com', 'B-', '1989-03-14', '2929 Pine Lane'),
('Jeremiah Weaver', 'M', '5551112222', 'jeremiah.weaver@example.com', 'AB+', '1995-07-27', '3030 Cedar Street'),
('Madelyn Mcdonald', 'F', '5552223333', 'madelyn.mcdonald@example.com', 'A-', '1991-12-10', '3131 Willow Lane'),
('Jordan Boyd', 'M', '5553334444', 'jordan.boyd@example.com', 'O+', '1997-04-23', '3232 Birch Avenue'),
('Gabriella Carpenter', 'F', '5554445555', 'gabriella.carpenter@example.com', 'B+', '1992-09-06', '3333 Elm Road'),
('Nicholas Mills', 'M', '5555556666', 'nicholas.mills@example.com', 'AB-', '1998-01-19', '3434 Oak Street'),
('Aubrey Wallace', 'F', '5556667777', 'aubrey.wallace@example.com', 'A+', '1993-05-02', '3535 Pine Lane'),
('Levi Cole', 'M', '5557778888', 'levi.cole@example.com', 'O-', '1988-08-15', '3636 Cedar Avenue'),
('Ariana Jennings', 'F', '5558889999', 'ariana.jennings@example.com', 'B-', '1994-12-28', '3737 Willow Road'),
('Dominic Castillo', 'M', '5559990000', 'dominic.castillo@example.com', 'AB+', '1990-06-11', '3838 Birch Lane'),
('Valentina Sandoval', 'F', '5550001111', 'valentina.sandoval@example.com', 'A-', '1996-10-24', '3939 Elm Street'),
('Adam Mendoza', 'M', '5551112222', 'adam.mendoza@example.com', 'O+', '1991-02-07', '4040 Oak Avenue'),
('Mariah Ramsey', 'F', '5552223333', 'mariah.ramsey@example.com', 'B+', '1997-06-20', '4141 Pine Road'),
('Cooper Reed', 'M', '5553334444', 'cooper.reed@example.com', 'AB-', '1992-11-03', '4242 Cedar Lane'),
('Luna Snyder', 'F', '5554445555', 'luna.snyder@example.com', 'A+', '1998-03-16', '4343 Willow Street'),
('Henry Hunt', 'M', '5555556666', 'henry.hunt@example.com', 'O-', '1993-07-29', '4444 Birch Avenue'),
('Willow Reid', 'F', '5556667777', 'willow.reid@example.com', 'B-', '1989-12-12', '4545 Elm Road'),
('Tristan Shelton', 'M', '5557778888', 'tristan.shelton@example.com', 'AB+', '1995-04-25', '4646 Oak Lane'),
('Delilah Goodman', 'F', '5558889999', 'delilah.goodman@example.com', 'A-', '1991-09-08', '4747 Pine Street'),
('Bentley Maldonado', 'M', '5559990000', 'bentley.maldonado@example.com', 'O+', '1996-01-21', '4848 Cedar Avenue'),
('Nova Marsh', 'F', '5550001111', 'nova.marsh@example.com', 'B+', '1992-05-04', '4949 Willow Lane'),
('Asher Hurley', 'M', '5551112222', 'asher.hurley@example.com', 'AB-', '1998-09-17', '5050 Birch Road'),
('Adeline Gregory', 'F', '5552223333', 'adeline.gregory@example.com', 'A+', '1993-01-30', '5151 Elm Street'),
('Emmett Watts', 'M', '5553334444', 'emmett.watts@example.com', 'O-', '1989-06-12', '5252 Oak Avenue'),
('Isabel Leonard', 'F', '5554445555', 'isabel.leonard@example.com', 'B-', '1995-10-25', '5353 Pine Lane'),
('Kai Bridges', 'M', '5555556666', 'kai.bridges@example.com', 'AB+', '1990-03-10', '5454 Cedar Road'),
('Raelynn Mccoy', 'F', '5556667777', 'raelynn.mccoy@example.com', 'A-', '1996-07-23', '5555 Willow Street'),
('Emmanuel Wolf', 'M', '5557778888', 'emmanuel.wolf@example.com', 'AB+', '1992-11-05', '5656 Birch Lane'),
('Adalyn Tucker', 'F', '5558889999', 'adalyn.tucker@example.com', 'A-', '1998-04-18', '5757 Elm Road'),
('Brayden Kim', 'M', '5559990000', 'brayden.kim@example.com', 'O+', '1993-08-01', '5858 Oak Lane'),
('Sarah Quinn', 'F', '5550001111', 'sarah.quinn@example.com', 'B+', '1989-12-14', '5959 Pine Avenue'),
('Theodore Baird', 'M', '5551112222', 'theodore.baird@example.com', 'AB-', '1995-04-27', '6060 Cedar Road'),
('Camila Stanton', 'F', '5552223333', 'camila.stanton@example.com', 'A+', '1991-09-10', '6161 Willow Lane'),
('Levi Dalton', 'M', '5553334444', 'levi.dalton@example.com', 'O-', '1997-01-23', '6262 Birch Street'),
('Alice Delgado', 'F', '5554445555', 'alice.delgado@example.com', 'B-', '1992-06-06', '6363 Elm Avenue'),
('Hunter Mathis', 'M', '5555556666', 'hunter.mathis@example.com', 'AB+', '1998-10-19', '6464 Oak Road'),
('Layla Mueller', 'F', '5556667777', 'layla.mueller@example.com', 'A-', '1993-02-01', '6565 Pine Lane'),
('Asher Stark', 'M', '5557778888', 'asher.stark@example.com', 'O+', '1988-06-14', '6666 Cedar Street'),
('Stella Mccormick', 'F', '5558889999', 'stella.mccormick@example.com', 'B+', '1994-11-27', '6767 Willow Avenue'),
('Roman Carson', 'M', '5559990000', 'roman.carson@example.com', 'AB-', '1990-05-10', '6868 Birch Lane'),
('Ariana Mccormick', 'F', '5550001111', 'ariana.mccormick@example.com', 'A+', '1996-09-23', '6969 Elm Road'),
('Hudson Flynn', 'M', '5551112222', 'hudson.flynn@example.com', 'O-', '1991-03-06', '7070 Oak Lane'),
('Mila Farley', 'F', '5552223333', 'mila.farley@example.com', 'B-', '1997-07-19', '7171 Pine Street'),
('Grayson Strong', 'M', '5553334444', 'grayson.strong@example.com', 'AB+', '1992-11-01', '7272 Cedar Avenue'),
('Aurora Cowan', 'F', '5554445555', 'aurora.cowan@example.com', 'A-', '1999-03-14', '7373 Willow Lane'),
('Lincoln Woodward', 'M', '5555556666', 'lincoln.woodward@example.com', 'O+', '1994-07-27', '7474 Birch Road'),
('Aubrey Farmer', 'F', '5556667777', 'aubrey.farmer@example.com', 'B+', '1989-12-10', '7575 Elm Street'),
('Elias Sellers', 'M', '5557778888', 'elias.sellers@example.com', 'AB-', '1995-04-23', '7676 Oak Avenue'),
('Isla Wade', 'F', '5558889999', 'isla.wade@example.com', 'A+', '1991-08-06', '7777 Pine Lane'),
('Mateo Hodge', 'M', '5559990000', 'mateo.hodge@example.com', 'O-', '1997-12-19', '7878 Cedar Road'),
('Avery Livingston', 'F', '5550001111', 'avery.livingston@example.com', 'B-', '1993-05-02', '7979 Willow Street'),
('Leo Bowers', 'M', '5551112222', 'leo.bowers@example.com', 'AB+', '1988-09-15', '8080 Birch Lane'),
('Nova Potts', 'F', '5552223333', 'nova.potts@example.com', 'A-', '1994-01-28', '8181 Elm Avenue'),
('Micah Benton', 'M', '5553334444', 'micah.benton@example.com', 'O+', '1999-06-11', '8282 Oak Lane'),
('Elena Mayer', 'F', '5554445555', 'elena.mayer@example.com', 'B+', '1992-10-24', '8383 Pine Road'),
('Ezra Serrano', 'M', '5555556666', 'ezra.serrano@example.com', 'AB-', '1998-02-07', '8484 Cedar Street'),
('Sadie Skinner', 'F', '5556667777', 'sadie.skinner@example.com', 'A+', '1993-06-20', '8585 Willow Lane'),
('Jayce Kane', 'M', '5557778888', 'jayce.kane@example.com', 'O-', '1989-12-03', '8686 Birch Avenue'),
('Ivy Mcintosh', 'F', '5558889999', 'ivy.mcintosh@example.com', 'B-', '1995-04-16', '8787 Elm Road'),
('Emmett Mata', 'M', '5559990000', 'emmett.mata@example.com', 'AB+', '1990-08-29', '8888 Oak Lane'),
('Isla Terrell', 'F', '5550001111', 'isla.terrell@example.com', 'A-', '1996-12-12', '8989 Pine Street'),
('Connor Burnett', 'M', '5551112222', 'connor.burnett@example.com', 'O+', '1992-05-25', '9090 Cedar Road'),
('Nora Dunlap', 'F', '5552223333', 'nora.dunlap@example.com', 'B+', '1997-10-08', '9191 Willow Avenue'),
('Jace Contreras', 'M', '5553334444', 'jace.contreras@example.com', 'AB-', '1993-02-21', '9292 Birch Lane'),
('Paisley Mcintosh', 'F', '5554445555', 'paisley.mcintosh@example.com', 'A+', '1998-07-06', '9393 Elm Street');

INSERT INTO public."Appointment" ("PatientId", "DoctorId", "AppointmentDate", "RoomId", "TokenId", "Status", "IsCancel")
VALUES
(5, 145, CURRENT_DATE + INTERVAL '1 month', 1, gen_random_uuid(), 'Pending', false),
(5, 146, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '1 day', 2, gen_random_uuid(), 'Pending', false),
(6, 147, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '2 days', 3, gen_random_uuid(), 'Pending', false),
(7, 148, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '3 days', 4, gen_random_uuid(), 'Pending', false),
(8, 149, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '4 days', 5, gen_random_uuid(), 'Pending', false),
(9, 150, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '5 days', 6, gen_random_uuid(), 'Pending', false),
(10, 151, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '6 days', 7, gen_random_uuid(), 'Pending', false),
(11, 152, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '7 days', 8, gen_random_uuid(), 'Pending', false),
(12, 153, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '8 days', 9, gen_random_uuid(), 'Pending', false),
(13, 154, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '9 days', 10, gen_random_uuid(), 'Pending', false),
(14, 155, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '10 days', 11, gen_random_uuid(), 'Pending', false),
(15, 156, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '11 days', 12, gen_random_uuid(), 'Pending', false),
(16, 157, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '12 days', 13, gen_random_uuid(), 'Pending', false),
(17, 158, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '13 days', 14, gen_random_uuid(), 'Pending', false),
(18, 159, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '14 days', 15, gen_random_uuid(), 'Pending', false),
(19, 160, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '15 days', 16, gen_random_uuid(), 'Pending', false),
(20, 161, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '16 days', 17, gen_random_uuid(), 'Pending', false),
(21, 162, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '17 days', 18, gen_random_uuid(), 'Pending', false),
(22, 163, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '18 days', 19, gen_random_uuid(), 'Pending', false),
(23, 164, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '19 days', 20, gen_random_uuid(), 'Pending', false),
(24, 165, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '20 days', 21, gen_random_uuid(), 'Pending', false),
(25, 166, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '21 days', 22, gen_random_uuid(), 'Pending', false),
(26, 167, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '22 days', 23, gen_random_uuid(), 'Pending', false),
(27, 168, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '23 days', 24, gen_random_uuid(), 'Pending', false),
(28, 169, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '24 days', 25, gen_random_uuid(), 'Pending', false),
(29, 170, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '25 days', 26, gen_random_uuid(), 'Pending', false),
(30, 171, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '26 days', 27, gen_random_uuid(), 'Pending', false),
(31, 172, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '27 days', 28, gen_random_uuid(), 'Pending', false),
(32, 173, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '28 days', 29, gen_random_uuid(), 'Pending', false),
(33, 174, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '29 days', 30, gen_random_uuid(), 'Pending', false),
(34, 175, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '30 days', 31, gen_random_uuid(), 'Pending', false),
(35, 176, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '31 days', 32, gen_random_uuid(), 'Pending', false),
(36, 177, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '32 days', 33, gen_random_uuid(), 'Pending', false),
(37, 178, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '33 days', 34, gen_random_uuid(), 'Pending', false),
(38, 179, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '34 days', 35, gen_random_uuid(), 'Pending', false),
(39, 180, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '35 days', 36, gen_random_uuid(), 'Pending', false),
(40, 181, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '36 days', 37, gen_random_uuid(), 'Pending', false),
(41, 182, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '37 days', 38, gen_random_uuid(), 'Pending', false),
(42, 183, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '38 days', 39, gen_random_uuid(), 'Pending', false),
(43, 184, CURRENT_DATE + INTERVAL '1 month' + INTERVAL '39 days', 40, gen_random_uuid(), 'Pending', false);




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
