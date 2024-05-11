import React from 'react';
const ButtonAbilities = ({children, ...prop}) => {
    function getCollor(type) {
        switch (type) {
            case 'bug':
                return '#079669';
            case 'dragon':
                return '#2dc4b6';
            case 'grass':
                return '#18bf71';
            case 'steel':
                return '#73e2a6';
            case 'dark':
                return '#444649';
            case 'flying':
                return '#8b9cad';
            case 'normal':
                return '#c18cba';
            case 'ghost':
                return '#9a55a1';
            case 'rock':
                return '#63320b';
            case 'ground':
                return '#885629';
            case 'fighting':
                return '#c75100';
            case 'fire':
                return '#ef271b';
            case 'electric':
                return '#ffbf00';
            case 'poison':
                return '#6e44ff';
            case 'psychic':
                return '#db00b6';
            case 'fairy':
                return '#ee4168';
            case 'water':
                return '#ee4168';
            case 'ice':
                return '#90e0ef';
            default:
                console.log(prop.type)
                return '';
        }
    }
    return (
        <div>
            
            <button {...prop} style={{backgroundColor: getCollor(prop.type)}}>
                {children}
            </button>
        </div>
    );
};

export default ButtonAbilities;