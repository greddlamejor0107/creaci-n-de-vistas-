CREATE VIEW vw_total_ventas_por_transportista AS
SELECT 
    t.nombre_transportista,
    SUM(v.monto_venta) AS total_ventas
FROM ventas v
JOIN transportistas t ON v.id_transportista = t.id_transportista
GROUP BY t.nombre_transportista;

-- SELECT para visualizar la vista
SELECT * FROM vw_total_ventas_por_transportista;