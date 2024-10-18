CREATE VIEW vw_productos_mas_vendidos_por_categoria AS
SELECT 
    c.nombre_categoria,
    p.nombre_producto,
    SUM(v.cantidad) AS total_vendido
FROM ventas v
JOIN productos p ON v.id_producto = p.id_producto
JOIN categorias c ON p.id_categoria = c.id_categoria
GROUP BY c.nombre_categoria, p.nombre_producto
ORDER BY c.nombre_categoria, total_vendido DESC;

-- SELECT para visualizar la vista
SELECT * FROM vw_productos_mas_vendidos_por_categoria;