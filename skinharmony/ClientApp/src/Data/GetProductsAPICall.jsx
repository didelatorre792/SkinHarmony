
const [data, setData] = useState([])
export const getProductsAPICall = () => {
    fetch("https://skincare-api.herokuapp.com/products", {method: 'GET'})
    .then((response) => response.json())
    .then((data) => {
        setData(data)
    });
}
//need callback function for 2nd .then