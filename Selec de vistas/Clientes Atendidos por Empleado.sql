CREATE VIEW vw_clientes_atendidos_por_empleado AS
SELECT 
    e.nombre_empleado,
    COUNT(DISTINCT v.id_cliente) AS clientes_atendidos
FROM ventas v
JOIN empleados e ON v.id_empleado = e.id_empleado
GROUP BY e.nombre_empleado;

-- SELECT para visualizar la vista
SELECT * FROM vw_clientes_atendidos_por_empleado;