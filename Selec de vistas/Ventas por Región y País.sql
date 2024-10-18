-- 4. Ventas por Región/País
CREATE VIEW vw_ventas_por_region AS
SELECT 
    r.id_region,
    r.nombre_region,
    SUM(v.monto_venta) AS total_ventas
FROM ventas v
JOIN clientes cl ON v.id_cliente = cl.id_cliente
JOIN regiones r ON cl.id_region = r.id_region
GROUP BY r.id_region, r.nombre_region ;

-- Consulta para mostrar los datos de la vista
SELECT * FROM vw_ventas_por_region;