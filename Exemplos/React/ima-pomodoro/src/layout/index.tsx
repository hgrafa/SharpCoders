import { Outlet } from "react-router-dom";
import { Header } from "../components/Header";

import styles from "./index.module.css";

export function DefaultLayoutContext() {
  return (
    <div className={styles.layout} >
      <Header />
      <Outlet />
    </div>
  )
}