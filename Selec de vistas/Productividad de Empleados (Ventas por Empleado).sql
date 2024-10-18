CREATE VIEW vw_productividad_empleados AS
SELECT 
    e.nombre_empleado,
    SUM(v.monto_venta) AS total_ventas
FROM ventas v
JOIN empleados e ON v.id_empleado = e.id_empleado
GROUP BY e.nombre_empleado;

-- SELECT para visualizar la vista
SELECT * FROM vw_productividad_empleados;
