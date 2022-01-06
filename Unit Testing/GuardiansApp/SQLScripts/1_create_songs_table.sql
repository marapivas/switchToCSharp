USE guardians;

CREATE TABLE songs (
id int NOT NULL AUTO_INCREMENT,
author varchar(255),
title varchar(255),
genre varchar(255),
year int,
rating int,
PRIMARY KEY (Id)
);


INSERT INTO `guardians`.`songs`
(`id`,
`author`,
`title`,
`genre`,
`year`,
`rating`)
VALUES
(1, "metalica", "enter sandman", "heavy metal", 1991, 10),
(2, "metalica", "nothing else matters", "heavy metal", 1991, 10),
(3, "acdc", "back in black", "hard rock", 1980, 5),
(4, "acdc", "hells bells", "hard rock", 1980, 8),
(5, "i love you honey bunny", "lazer queen", "indie rock", 2018, 10),
(6, "i love you honey bunny", "we run", "indie rock", 2018, 9)