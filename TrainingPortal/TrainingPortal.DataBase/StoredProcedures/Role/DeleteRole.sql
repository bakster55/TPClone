﻿CREATE PROCEDURE [dbo].[DeleteRole]
	@id INT OUTPUT
AS
	DELETE FROM [Role] WHERE Id = @id
RETURN 0