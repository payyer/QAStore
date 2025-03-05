import { useEffect, useState } from "react";
import { Product } from "../../app/models/product";
import ProductList from "./ProductList";

export default function Catalog() {
  const [products, setProducts] = useState<Product[]>([]);

  useEffect(() => {
    fetch("http://localhost:5163/api/Products")
      .then((res) => res.json())
      .then((data) => {
        console.log({ data });
        return setProducts(data);
      });
  }, []);

  return (
    <>
      <ProductList products={products} />
    </>
  );
}
