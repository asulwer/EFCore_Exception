CREATE DATABASE demo
GO

USE demo;
GO

DROP TABLE IF EXISTS item;
GO

CREATE TABLE item (
  Id int identity(1,1) NOT NULL primary key,
  ItemName varchar(100) DEFAULT NULL,
  ItemDesc varchar(100) DEFAULT NULL,
  TS datetime NOT NULL DEFAULT getdate()
);
GO

INSERT INTO item (ItemName,ItemDesc) VALUES('test','test');