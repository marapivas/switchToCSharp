USE guardians;

CREATE TABLE foods (
id int NOT NULL AUTO_INCREMENT,
name varchar(255),
amount int,
calorie int,
PRIMARY KEY (Id)
);


INSERT INTO `guardians`.`foods`
(`id`,
`name`,
`amount`,
`calorie`)
VALUES
(1, "banana", 2, 94),
(2, "orange", 1, 47);