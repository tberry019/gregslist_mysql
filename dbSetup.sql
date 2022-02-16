CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL primary key COMMENT 'primary key',
  createdAt DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Time Created',
  updatedAt DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'Last Update',
  name varchar(255) COMMENT 'User Name',
  email varchar(255) COMMENT 'User Email',
  picture varchar(255) COMMENT 'User Picture'
) default charset utf8 COMMENT '';

CREATE TABLE cars (  
    id INT NOT NULL PRIMARY KEY AUTO_INCREMENT COMMENT 'Primary Key',
    create_time DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Create Time',
    update_time DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'Update Time',
    price INT NOT NULL COMMENT 'Price',
    make TEXT NOT NULL COMMENT 'Make',
    model TEXT NOT NULL COMMENT 'Model',
    modelYear INT NOT NULL COMMENT 'Year',
    description TEXT NOT NULL COMMENT 'Description',
    imgurl TEXT NOT NULL COMMENT 'ImgUrl'
) DEFAULT CHARSET UTF8 COMMENT 'Cars';