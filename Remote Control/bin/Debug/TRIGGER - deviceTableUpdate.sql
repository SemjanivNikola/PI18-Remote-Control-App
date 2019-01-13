CREATE TRIGGER update_wasMachine_table 
AFTER INSERT ON device 
FOR EACH ROW 
BEGIN 
	INSERT INTO WasMachine 
	SELECT sn, type, name, model, date, time, pass_tpe, pass 
	FROM device WHERE type = 'Washing Machine'; 
END