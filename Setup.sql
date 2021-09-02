CREATE TABLE castles (  
    id int NOT NULL primary key AUTO_INCREMENT comment 'primary key',
    name varchar(255) NOT NULL comment 'castle name',
    location varchar(255) comment 'location',
    picture varchar(255) comment 'picture of castle'
) default charset utf8 comment '';

INSERT INTO
  castles (name, location, picture)
VALUES
  ('Sir Lance', 'England', 'https://images.unsplash.com/photo-1553434320-e9f5757140b1?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=282&q=80');

SELECT * FROM castles;

SELECT * FROM castles WHERE id = 5;

UPDATE castles SET name = "Sir LanceALot" WHERE id = 5;

DELETE FROM castles WHERE id = 6;

DELETE FROM castles;

DROP TABLE castles;


