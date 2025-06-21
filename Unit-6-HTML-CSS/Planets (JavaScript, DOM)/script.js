const planets = [
    {
        name: "Mercury", 
        inner: true,
        diameter: 3031.9,
        color: "#696969"
    },
    {
        name: "Venus", 
        inner: true,
        diameter: 7520.8,
        color: "#b89165"
    },
    {
        name: "Earth", 
        inner: true,
        diameter: 7917.5,
        color: "#5a5b86"
    },
    {
        name: "Mars", 
        inner: true,
        diameter: 4212.3,
        color: "#df8c4e"
    },
    {
        name: "Jupiter", 
        inner: false,
        diameter: 86881,
        color: "#f6a049"
    },
    {
        name: "Saturn", 
        inner: false,
        diameter: 72367,
        color: "#dcd3a1"
    },
    {
        name: "Uranus", 
        inner: false,
        diameter: 31518,
        color: "#b4d9df"
    },           
    {
        name: "Neptune", 
        inner: false,
        diameter: 30599,
        color: "#456eff"
    } 
];

planets.forEach(function(planet) {
    console.log(planet.name);
});

const sumOfValues = planets.reduce((accumulator, currentValue) => {
  return accumulator + currentValue.diameter;
}, 0);

console.log("Average Diameter: ",sumOfValues / 8);

let index = 0;
const indexText = document.querySelector(".index");
const previousButton = document.getElementById("previous");
const nextButton = document.getElementById("next");

previousButton.disabled = true;
previousButton.addEventListener("click", function() {
    index -=1;
    indexText.textContent = `Index: ${index}`;

    if (index === 0) previousButton.disabled = true;
    else previousButton.disabled = false;
    if (index < planets.length - 1) nextButton.disabled = false;
    updatePlanetDisplay(planets[index].name,planets[index].inner,planets[index].diameter,planets[index].color);
});

nextButton.addEventListener("click", function() {
    index +=1;
    indexText.textContent = `Index: ${index}`;

    if (index > 0) previousButton.disabled = false;
    if (index === planets.length - 1) nextButton.disabled = true;
    updatePlanetDisplay(planets[index].name,planets[index].inner,planets[index].diameter,planets[index].color);
});

updatePlanetDisplay(planets[index].name,planets[index].inner,planets[index].diameter,planets[index].color);
function updatePlanetDisplay(name,inner,diameter,color) {
    const currentPlanet = document.querySelector(".current-planet");
    const planetContainer = document.createElement("div");
    const planetHeader = document.createElement("h2");
    const innerHeader = document.createElement("p");
    const planet = document.createElement("div");
    currentPlanet.innerHTML = "";
    planetHeader.textContent = name;
    innerHeader. textContent = inner ? "Inner Planet": "Outer Planet";
    planet.className = "planet";
    planet.style.width = `${diameter / 100}px`;
    planet.style.height = `${diameter / 100}px`;
    planet.style.backgroundColor = color;
    planetContainer.append(planetHeader);
    planetContainer.append(innerHeader);
    planetContainer.append(planet);
    currentPlanet.append(planetContainer);
}