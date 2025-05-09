-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 09, 2025 at 08:09 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sis`
--

-- --------------------------------------------------------

--
-- Table structure for table `course`
--

CREATE TABLE `course` (
  `course_id` int(11) NOT NULL,
  `course_code` varchar(20) NOT NULL,
  `course_name` varchar(150) NOT NULL,
  `description` text DEFAULT NULL,
  `units` int(11) DEFAULT NULL,
  `department_code` varchar(11) DEFAULT NULL,
  `program_type` enum('Undergraduate','Graduate','Diploma','Foundation','Doctorate') NOT NULL,
  `level` int(11) DEFAULT NULL,
  `semester_offered` enum('1st','2nd','3rd','1st, 2nd','All') DEFAULT NULL,
  `prerequisite_ids` text DEFAULT NULL,
  `status` varchar(20) DEFAULT 'Active',
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `course`
--

INSERT INTO `course` (`course_id`, `course_code`, `course_name`, `description`, `units`, `department_code`, `program_type`, `level`, `semester_offered`, `prerequisite_ids`, `status`, `created_at`, `updated_at`) VALUES
(1, 'asd', 'easd', 'asdegfewt', 0, '', 'Undergraduate', 1, '2nd', 'IntegProg, OOP', 'Active', '2025-05-09 17:18:20', '2025-05-09 17:18:20');

-- --------------------------------------------------------

--
-- Table structure for table `coursefee`
--

CREATE TABLE `coursefee` (
  `fee_id` int(11) NOT NULL,
  `course_id` int(11) DEFAULT NULL,
  `academic_year` varchar(10) DEFAULT NULL,
  `amount` decimal(10,2) DEFAULT NULL,
  `currency` varchar(10) DEFAULT NULL,
  `notes` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `coursefee`
--

INSERT INTO `coursefee` (`fee_id`, `course_id`, `academic_year`, `amount`, `currency`, `notes`) VALUES
(1, 1, NULL, 40600.00, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `department`
--

CREATE TABLE `department` (
  `department_id` int(11) NOT NULL,
  `department_name` varchar(100) NOT NULL,
  `code` varchar(10) NOT NULL,
  `head_of_department` varchar(150) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `office_location` varchar(100) DEFAULT NULL,
  `status` varchar(20) DEFAULT 'Active',
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `enrollment`
--

CREATE TABLE `enrollment` (
  `enrollment_id` int(11) NOT NULL,
  `student_id` int(11) DEFAULT NULL,
  `academic_term` varchar(9) DEFAULT NULL,
  `semester` enum('1st','2nd','Summer') DEFAULT NULL,
  `course_code` varchar(20) DEFAULT NULL,
  `payment_plan` enum('Full','Low Downpayment','Low Monthly') DEFAULT NULL,
  `total_due` decimal(10,2) DEFAULT NULL,
  `enrollment_date` date DEFAULT NULL,
  `status` enum('Enrolled','Dropped','Pending') DEFAULT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `enrollment`
--

INSERT INTO `enrollment` (`enrollment_id`, `student_id`, `academic_term`, `semester`, `course_code`, `payment_plan`, `total_due`, `enrollment_date`, `status`, `created_at`, `updated_at`) VALUES
(1, 1, '2025 - 20', '1st', 'asd', NULL, NULL, '2025-05-07', NULL, '2025-05-09 17:34:11', '2025-05-09 17:34:11'),
(3, 3, '2025 - 20', '1st', 'asd', 'Full', NULL, '2025-05-07', NULL, '2025-05-09 17:41:19', '2025-05-09 17:41:19');

-- --------------------------------------------------------

--
-- Table structure for table `faculty`
--

CREATE TABLE `faculty` (
  `staff_id` int(11) NOT NULL,
  `teacher_code` varchar(5) NOT NULL,
  `surname` varchar(50) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `middle_name` varchar(50) DEFAULT NULL,
  `suffix` enum('Jr.','Sr.','II','III','PhD','EdD','MD','DVM','CPA','RN','Esq.','') DEFAULT NULL,
  `date_of_birth` date NOT NULL,
  `gender` enum('M','F','O','') NOT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `employment_type` enum('Full-Time','Part-Time','Contractual') DEFAULT NULL,
  `role` enum('Admin','Faculty','Staff') DEFAULT NULL,
  `position` enum('Academic Adviser','Academic Affairs Officer','Admissions Officer','Assistant Registrar','Curriculum Coordinator','Database Administrator','Dean','Department Chair','Enrollment Officer','Finance/Billing Staff','Guidance Counselor','Instructor',' IT Support Staff','Librarian','Lecturer','Program Coordinator','Professor','Records Clerk','Registrar','Scheduling Officer','School Nurse','System Administrator') DEFAULT NULL,
  `department` varchar(10) DEFAULT NULL,
  `created_at` datetime NOT NULL DEFAULT current_timestamp(),
  `updated_at` datetime NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `status` enum('Active','On Leave','Resigned','Suspended','Retired','Terminated') NOT NULL,
  `photo` blob DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `payments`
--

CREATE TABLE `payments` (
  `payment_id` int(11) NOT NULL,
  `enrollment_id` int(11) DEFAULT NULL,
  `amount_paid` decimal(10,2) DEFAULT NULL,
  `payment_date` datetime DEFAULT NULL,
  `payment_stage` enum('Enrollment Fee','1st Installment','2nd Installment','3rd Installment','4th Installment') DEFAULT NULL,
  `payment_method` enum('Cash','Gcash','Bank','Card','Online') DEFAULT NULL,
  `reference_no` varchar(50) DEFAULT NULL,
  `remarks` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `students`
--

CREATE TABLE `students` (
  `student_id` int(11) NOT NULL,
  `student_number` varchar(20) DEFAULT NULL,
  `first_name` varchar(50) NOT NULL,
  `last_name` varchar(50) NOT NULL,
  `middle_name` varchar(50) DEFAULT NULL,
  `suffix` enum('Jr.','Sr.','II','III','PhD','EdD','MD','DVM','CPA','RN','Esq.','') NOT NULL,
  `date_of_birth` date DEFAULT NULL,
  `gender` enum('M','F','O') DEFAULT NULL,
  `course_code` varchar(20) DEFAULT NULL,
  `year_level` int(11) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `status` varchar(20) DEFAULT 'active',
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `photo` blob DEFAULT NULL,
  `guardian_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `students`
--

INSERT INTO `students` (`student_id`, `student_number`, `first_name`, `last_name`, `middle_name`, `suffix`, `date_of_birth`, `gender`, `course_code`, `year_level`, `email`, `phone`, `status`, `created_at`, `photo`, `guardian_id`) VALUES
(1, NULL, 'Ivan', 'Diocampo', 'Sib', '', '2025-05-07', 'M', NULL, NULL, '', '', 'Pending', '2025-05-09 17:34:10', NULL, NULL),
(3, NULL, 'COARL', 'BUNYI', 'LUL', '', '2025-05-07', 'O', NULL, NULL, '', '', 'Pending', '2025-05-09 17:41:18', NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `student_guardian`
--

CREATE TABLE `student_guardian` (
  `id` int(11) NOT NULL,
  `guardian` enum('Father','Mother','Legal Guardian','Grandparent','Sibling','Aunt/Uncle','Cousin','Stepfather','Stepmother','Foster Parent','Other') NOT NULL,
  `surname` varchar(50) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `middle_int` varchar(5) DEFAULT NULL,
  `phone` varchar(20) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `student_guardian`
--

INSERT INTO `student_guardian` (`id`, `guardian`, `surname`, `firstname`, `middle_int`, `phone`, `email`) VALUES
(1, '', '1st', 'asd', '', '', ''),
(2, '', '1st', 'asd', '', '', ''),
(3, '', '1st', 'asd', '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `subjects`
--

CREATE TABLE `subjects` (
  `subject_id` int(11) NOT NULL,
  `subject_code` varchar(20) NOT NULL,
  `subject_name` varchar(150) NOT NULL,
  `description` text DEFAULT NULL,
  `units` int(11) NOT NULL,
  `course_code` varchar(20) DEFAULT NULL,
  `year_level` int(11) DEFAULT NULL,
  `semester` enum('1st','2nd','3rd') DEFAULT NULL,
  `department` varchar(10) DEFAULT NULL,
  `prerequisites` text DEFAULT NULL,
  `status` varchar(20) DEFAULT 'Active',
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `subjects`
--

INSERT INTO `subjects` (`subject_id`, `subject_code`, `subject_name`, `description`, `units`, `course_code`, `year_level`, `semester`, `department`, `prerequisites`, `status`, `created_at`, `updated_at`) VALUES
(1, 'OOP', 'Object Oriented Programing', 'oop lamang', 0, NULL, 1, NULL, '', '', 'Active', '2025-05-09 15:56:05', '2025-05-09 15:56:05'),
(2, 'IntegProg', 'Integrative Programming', '', 0, NULL, 2, NULL, '', '', 'Active', '2025-05-09 16:00:24', '2025-05-09 16:00:24');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`course_id`),
  ADD UNIQUE KEY `course_code` (`course_code`),
  ADD KEY `fk_department` (`department_code`);

--
-- Indexes for table `coursefee`
--
ALTER TABLE `coursefee`
  ADD PRIMARY KEY (`fee_id`),
  ADD KEY `course_id` (`course_id`);

--
-- Indexes for table `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`department_id`),
  ADD UNIQUE KEY `code` (`code`);

--
-- Indexes for table `enrollment`
--
ALTER TABLE `enrollment`
  ADD PRIMARY KEY (`enrollment_id`),
  ADD KEY `student_id` (`student_id`),
  ADD KEY `course_code` (`course_code`);

--
-- Indexes for table `faculty`
--
ALTER TABLE `faculty`
  ADD PRIMARY KEY (`staff_id`);

--
-- Indexes for table `payments`
--
ALTER TABLE `payments`
  ADD PRIMARY KEY (`payment_id`),
  ADD KEY `enrollment_id` (`enrollment_id`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD PRIMARY KEY (`student_id`),
  ADD UNIQUE KEY `student_number` (`student_number`),
  ADD KEY `course_code` (`course_code`);

--
-- Indexes for table `student_guardian`
--
ALTER TABLE `student_guardian`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `subjects`
--
ALTER TABLE `subjects`
  ADD PRIMARY KEY (`subject_id`),
  ADD UNIQUE KEY `subject_code` (`subject_code`),
  ADD KEY `fk_subject_course` (`course_code`),
  ADD KEY `fk_dept` (`department`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `course`
--
ALTER TABLE `course`
  MODIFY `course_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `coursefee`
--
ALTER TABLE `coursefee`
  MODIFY `fee_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `department`
--
ALTER TABLE `department`
  MODIFY `department_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `enrollment`
--
ALTER TABLE `enrollment`
  MODIFY `enrollment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `faculty`
--
ALTER TABLE `faculty`
  MODIFY `staff_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `payments`
--
ALTER TABLE `payments`
  MODIFY `payment_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `student_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `student_guardian`
--
ALTER TABLE `student_guardian`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `subjects`
--
ALTER TABLE `subjects`
  MODIFY `subject_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `coursefee`
--
ALTER TABLE `coursefee`
  ADD CONSTRAINT `coursefee_ibfk_1` FOREIGN KEY (`course_id`) REFERENCES `course` (`course_id`);

--
-- Constraints for table `enrollment`
--
ALTER TABLE `enrollment`
  ADD CONSTRAINT `enrollment_ibfk_1` FOREIGN KEY (`student_id`) REFERENCES `students` (`student_id`),
  ADD CONSTRAINT `enrollment_ibfk_2` FOREIGN KEY (`course_code`) REFERENCES `course` (`course_code`);

--
-- Constraints for table `payments`
--
ALTER TABLE `payments`
  ADD CONSTRAINT `payments_ibfk_1` FOREIGN KEY (`enrollment_id`) REFERENCES `enrollment` (`enrollment_id`);

--
-- Constraints for table `students`
--
ALTER TABLE `students`
  ADD CONSTRAINT `students_ibfk_1` FOREIGN KEY (`course_code`) REFERENCES `courses` (`course_code`);

--
-- Constraints for table `subjects`
--
ALTER TABLE `subjects`
  ADD CONSTRAINT `fk_subject_course` FOREIGN KEY (`course_code`) REFERENCES `course` (`course_code`) ON DELETE SET NULL;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
