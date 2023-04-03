import {Route, Routes} from "react-router-dom"
import { DefaultLayoutContext } from "./layout"
import { Home } from "./pages/Home"
import { Statistcs } from "./pages/Statistics"

export function Router() {
  return (
    <Routes>
      <Route path="/" element={<DefaultLayoutContext />}>
        <Route path="/" element={<Home />} />
        <Route path="/stats" element={<Statistcs />} />
      </Route>
    </Routes>
  )
}