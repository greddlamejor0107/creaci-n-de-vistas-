CREATE VIEW vw_pedidos_por_empleado AS
SELECT 
    e.nombre_empleado,
    COUNT(v.id_venta) AS numero_pedidos
FROM ventas v
JOIN empleados e ON v.id_empleado = e.id_empleado
GROUP BY e.nombre_empleado;

-- SELECT para visualizar la vista
SELECT * FROM vw_pedidos_por_empleado;
