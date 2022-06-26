create database scrum;

CREATE TABLE `users` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `lastname` varchar(255),
  `firstname` varchar(255),
  `email` varchar(255),
  `password` varchar(255)
);

CREATE TABLE `Member` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `Project_id` int,
  `pinned` boolean NULL DEFAULT FALSE,
  `role` varchar(255),
  `user_id` int
);

CREATE TABLE `Project` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `name` varchar(255),
  `description` varchar(255),
  `archived` boolean,
  `created_dt` date
);

CREATE TABLE `Sprint` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `name` varchar(255),
  `startDate` date,
  `endDate` date,
  `Project_id` int
);

CREATE TABLE `UserStory` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `name` varchar(255),
  `description` varchar(255),
  `complexity` int,
  `priority` int,
  `state` varchar(100),
  `sprint_id` int,
  `Project_id` int NOT NULL
);

CREATE TABLE `UserStoryComment` (
  `id` int PRIMARY KEY AUTO_INCREMENT,
  `description` varchar(255),
  `date` datetime,
  `member_id` int,
  `userstory_id` int
);

CREATE TABLE `UserStoryMember` (
  `id` int,
  `member_id` int,
  `userstory_id` int
);

ALTER TABLE `users` ADD FOREIGN KEY (`id`) REFERENCES `Member` (`user_id`);

ALTER TABLE `Member` ADD FOREIGN KEY (`Project_id`) REFERENCES `Project` (`id`);

ALTER TABLE `Sprint` ADD FOREIGN KEY (`Project_id`) REFERENCES `Project` (`id`);

ALTER TABLE `UserStory` ADD FOREIGN KEY (`Project_id`) REFERENCES `Project` (`id`);

ALTER TABLE `UserStoryComment` ADD FOREIGN KEY (`userstory_id`) REFERENCES `UserStory` (`id`);

ALTER TABLE `UserStoryComment` ADD FOREIGN KEY (`member_id`) REFERENCES `Member` (`id`);

ALTER TABLE `UserStoryMember` ADD FOREIGN KEY (`member_id`) REFERENCES `Member` (`id`);

ALTER TABLE `UserStoryMember` ADD FOREIGN KEY (`userstory_id`) REFERENCES `UserStory` (`id`);
