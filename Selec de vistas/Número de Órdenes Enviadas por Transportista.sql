-- 11. Número de Órdenes Enviadas por Transportista
CREATE VIEW vw_ordenes_enviadas_por_transportista AS
SELECT 
    t.nombre_transportista,
    COUNT(v.id_venta) AS numero_ordenes
FROM ventas v
JOIN transportistas t ON v.id_transportista = t.id_transportista
GROUP BY t.nombre_transportista;

-- SELECT para visualizar la vista
SELECT * FROM vw_ordenes_enviadas_por_transportista;