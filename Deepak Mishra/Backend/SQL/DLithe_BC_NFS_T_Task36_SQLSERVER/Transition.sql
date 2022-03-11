CREATE TABLE dbo.EmployeePhoto
(EmployeeId      INT NOT NULL PRIMARY KEY, 
 Photo           VARBINARY(MAX) NULL, 
 MyRowGuidColumn UNIQUEIDENTIFIER NOT NULL
                                  ROWGUIDCOL UNIQUE
                                             DEFAULT NEWID()
);

use crud

SELECT connection_id,session_id,client_net_address,auth_scheme
FROM sys.dm_exec_connections ;


--transition query
use functions
BEGIN TRANSACTION  
INSERT INTO student VALUES('deepakmishramm','08/09/1998')  ;
-- Check for error  
IF(@@ERROR > 0)  
BEGIN  
    ROLLBACK TRANSACTION  
END  
ELSE  
BEGIN  
   COMMIT TRANSACTION  
END 

