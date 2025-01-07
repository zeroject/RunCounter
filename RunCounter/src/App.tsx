import { useAuth0 } from "@auth0/auth0-react"
import { Button } from "./components/ui/button"
import { Route, Routes } from "react-router-dom";
import Home from "./pages/Home";


function App() {

  const { loginWithRedirect, logout, isAuthenticated } = useAuth0();

  return (
    <>
      <div className="flex justify-end p-4">
        {isAuthenticated ? (
          <Button onClick={() => logout()}>
            Log Out
          </Button> 
        ) : (
        <Button onClick={() => loginWithRedirect()}>
          Log In
        </Button>
      )} 
      </div>
      <div>
        <Routes>
          <Route path="/" element={<Home />} />
        </Routes>
      </div>
    </>
  )
}

export default App