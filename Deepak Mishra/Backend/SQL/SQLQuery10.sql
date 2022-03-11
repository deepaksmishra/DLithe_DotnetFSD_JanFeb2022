use crud

create proc  [dbo].[Usp_Login]  
@UserName varchar(50)='',  
@Password varchar(50)=''  
as begin  
    declare @UserId int =0,@TotalCnt int =0  
    select @UserId=UserId,@TotalCnt=TotalCnt from  Employeemaster um   
    where LoginName=@UserName and Password=@Password and Status<>3 and IsApporved=1  
    if(@TotalCnt>=5)  
    begin  
       select 0 UserId,'' UserName,'' LoginName,'' Password,'' Email,'' ContactNo,   
    ''Address,0 IsApporved,-1 Status  
    end  
    if(@UserId>0)  
    begin  
        select UserId, UserName, LoginName, Password, Email, ContactNo,   
        Address, IsApporved, Status from  Employeemaster um   
        where UserId=@UserId   
        --update  Employeemaster  set  Status=2 where UserId=@UserId   
      
    end  
    else  
    begin  
       Update Employeemaster set @TotalCnt=TotalCnt+1    
       where LoginName=@UserName and Status=1 and IsApporved=1  
       select 0 UserId,'' UserName,'' LoginName,'' Password,'' Email,'' ContactNo,   
    ''Address,0 IsApporved,0 Status  
    end  
    end  