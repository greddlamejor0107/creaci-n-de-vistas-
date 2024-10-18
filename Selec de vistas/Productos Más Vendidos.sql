CREATE VIEW vw_productos_mas_vendidos AS
SELECT 
    p.nombre_producto,
    SUM(v.cantidad) AS total_vendido
FROM ventas v
JOIN productos p ON v.id_producto = p.id_producto
GROUP BY p.nombre_producto
ORDER BY total_vendido DESC;

-- SELECT para visualizar la vista
SELECT * FROM vw_productos_mas_vendidos;