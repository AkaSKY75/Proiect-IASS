using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace XMLGenerator
{
    class Program
    {
        public static void createXml(List<Patient> patientsList)
        {
            foreach(Patient patient in patientsList)
            {
                // Create XML Document and the root for it
                XmlDocument xml = new XmlDocument();
                XmlDeclaration xml_declaration = xml.CreateXmlDeclaration("1.0", "utf-8", "");
                xml.AppendChild(xml_declaration);
                XmlNode root = xml.CreateNode(XmlNodeType.Element, "Patient", "");
                xml.AppendChild(root);

                #region Create identifier TAG

                XmlNode identifier = xml.CreateNode(XmlNodeType.Element, "identifier", "");
                root.AppendChild(identifier);

                #region Create IDENTIFIER childs TAG

                #region Create USE TAG

                XmlNode use = xml.CreateNode(XmlNodeType.Element, "use", "");
                XmlAttribute useValue = xml.CreateAttribute("value");
                use.Attributes.Append(useValue);
                useValue.Value = patient.identifier.use;
                identifier.AppendChild(use);
                
                #endregion

                #region Create TYPE TAG

                XmlNode type = xml.CreateNode(XmlNodeType.Element, "type", "");
                identifier.AppendChild(type);

                #region Create TYPE(CodeableConcept) childs TAG

                XmlNode coding = xml.CreateNode(XmlNodeType.Element, "coding", "");
                type.AppendChild(coding);

                #region Create Coding(Coding) childs TAG

                XmlNode system = xml.CreateNode(XmlNodeType.Element, "system", "");
                XmlAttribute systemValue = xml.CreateAttribute("value");
                system.Attributes.Append(systemValue);
                systemValue.Value = patient.identifier.type.coding.system;
                coding.AppendChild(system);
                XmlNode version = xml.CreateNode(XmlNodeType.Element, "version", "");
                XmlAttribute versionValue = xml.CreateAttribute("value");
                version.Attributes.Append(versionValue);
                versionValue.Value = patient.identifier.type.coding.version;
                coding.AppendChild(version);
                XmlNode code = xml.CreateNode(XmlNodeType.Element, "code", "");
                XmlAttribute codeValue = xml.CreateAttribute("value");
                code.Attributes.Append(codeValue);
                codeValue.Value = patient.identifier.type.coding.code;
                coding.AppendChild(code);
                XmlNode display = xml.CreateNode(XmlNodeType.Element, "display", "");
                XmlAttribute displayValue = xml.CreateAttribute("value");
                display.Attributes.Append(displayValue);
                displayValue.Value = patient.identifier.type.coding.display;
                coding.AppendChild(display);
                XmlNode userSelected = xml.CreateNode(XmlNodeType.Element, "userSelected", "");
                XmlAttribute userSelectedValue = xml.CreateAttribute("value");
                userSelected.Attributes.Append(userSelectedValue);
                userSelectedValue.Value = patient.identifier.type.coding.userSelected.ToString();
                coding.AppendChild(userSelected);
                #endregion

                XmlNode text = xml.CreateNode(XmlNodeType.Element, "text", "");
                XmlAttribute textValue = xml.CreateAttribute("value");
                text.Attributes.Append(textValue);
                textValue.Value = patient.identifier.type.text;
                type.AppendChild(text);

                #endregion

                #endregion

                #region Create SYSTEM TAG

                XmlNode systemS = xml.CreateNode(XmlNodeType.Element, "system", "");
                XmlAttribute systemSValue = xml.CreateAttribute("value");
                systemS.Attributes.Append(systemSValue);
                systemSValue.Value = patient.identifier.system;
                identifier.AppendChild(systemS);

                #endregion

                #region Create VALUE TAG

                XmlNode value = xml.CreateNode(XmlNodeType.Element, "value", "");
                XmlAttribute valueValue = xml.CreateAttribute("value");
                value.Attributes.Append(valueValue);
                valueValue.Value = patient.identifier.value;
                identifier.AppendChild(value);

                #endregion

                #region Create PERIOD TAG
                XmlNode period = xml.CreateNode(XmlNodeType.Element, "period", "");
                identifier.AppendChild(period);

                #region Create PERIOD childs TAG

                XmlNode start = xml.CreateNode(XmlNodeType.Element, "start", "");
                XmlAttribute startValue = xml.CreateAttribute("value");
                start.Attributes.Append(startValue);
                startValue.Value = patient.identifier.period.Start.ToString();
                period.AppendChild(start);

                XmlNode end = xml.CreateNode(XmlNodeType.Element, "end", "");
                XmlAttribute endValue = xml.CreateAttribute("value");
                end.Attributes.Append(endValue);
                endValue.Value = patient.identifier.period.End.ToString();
                period.AppendChild(end);

                #endregion

                #endregion

                #region Create ASSIGNER TAG

                XmlNode assigner = xml.CreateNode(XmlNodeType.Element, "assigner", "");
                identifier.AppendChild(assigner);

                #endregion

                #endregion

                #endregion

                XmlNode active = xml.CreateNode(XmlNodeType.Element, "active", "");
                XmlAttribute activeValue = xml.CreateAttribute("value");
                activeValue.Value = patient.active.ToString();
                active.Attributes.Append(activeValue);
                root.AppendChild(active);

                XmlNode name = xml.CreateNode(XmlNodeType.Element, "name", "");
                root.AppendChild(name);

                #region Create NAME(HUMAN NAME) TAG

                XmlNode useN = xml.CreateNode(XmlNodeType.Element, "use", "");
                XmlAttribute useNValue = xml.CreateAttribute("value");
                useN.Attributes.Append(useNValue);
                useNValue.Value = patient.name.use;
                name.AppendChild(useN);

                XmlNode textN = xml.CreateNode(XmlNodeType.Element, "text", "");
                XmlAttribute textNValue = xml.CreateAttribute("value");
                textN.Attributes.Append(textNValue);
                textNValue.Value = patient.name.text;
                name.AppendChild(textN);

                XmlNode family = xml.CreateNode(XmlNodeType.Element, "family", "");
                XmlAttribute familyValue = xml.CreateAttribute("value");
                family.Attributes.Append(familyValue);
                familyValue.Value = patient.name.family;
                name.AppendChild(family);

                XmlNode given = xml.CreateNode(XmlNodeType.Element, "given", "");
                XmlAttribute givenValue = xml.CreateAttribute("value");
                given.Attributes.Append(givenValue);
                givenValue.Value = patient.name.given;
                name.AppendChild(given);

                XmlNode prefix = xml.CreateNode(XmlNodeType.Element, "prefix", "");
                XmlAttribute prefixValue = xml.CreateAttribute("value");
                prefix.Attributes.Append(prefixValue);
                prefixValue.Value = patient.name.prefix;
                name.AppendChild(prefix);

                XmlNode suffix = xml.CreateNode(XmlNodeType.Element, "suffix", "");
                XmlAttribute suffixValue = xml.CreateAttribute("value");
                suffix.Attributes.Append(suffixValue);
                suffixValue.Value = patient.name.suffix;
                name.AppendChild(suffix);

                #region Create PERIOD TAG
                XmlNode periodN = xml.CreateNode(XmlNodeType.Element, "period", "");
                name.AppendChild(periodN);

                #region Create PERIOD childs TAG

                XmlNode startN = xml.CreateNode(XmlNodeType.Element, "start", "");
                XmlAttribute startNValue = xml.CreateAttribute("value");
                startN.Attributes.Append(startNValue);
                startNValue.Value = patient.name.period.Start.ToString();
                periodN.AppendChild(startN);

                XmlNode endN = xml.CreateNode(XmlNodeType.Element, "end", "");
                XmlAttribute endNalue = xml.CreateAttribute("value");
                endN.Attributes.Append(endNalue);
                endNalue.Value = patient.name.period.End.ToString();
                periodN.AppendChild(endN);

                #endregion

                #endregion


                #endregion

                #region Create TELECOM TAG

                XmlNode telecom = xml.CreateNode(XmlNodeType.Element, "telecom", "");
                root.AppendChild(telecom);

                #region Create TELECOM(CONTACT POINT) childs TAG

                XmlNode systemT = xml.CreateNode(XmlNodeType.Element, "system", "");
                XmlAttribute systemTValue = xml.CreateAttribute("value");
                systemT.Attributes.Append(systemTValue);
                systemTValue.Value = patient.telecom.system;
                telecom.AppendChild(systemT);

                XmlNode valueT = xml.CreateNode(XmlNodeType.Element, "value", "");
                XmlAttribute valueTValue = xml.CreateAttribute("value");
                valueT.Attributes.Append(valueTValue);
                valueTValue.Value = patient.telecom.value;
                telecom.AppendChild(valueT);

                XmlNode useT = xml.CreateNode(XmlNodeType.Element, "use", "");
                XmlAttribute useTValue = xml.CreateAttribute("value");
                useT.Attributes.Append(useTValue);
                useTValue.Value = patient.telecom.use;
                telecom.AppendChild(useT);

                XmlNode rankT = xml.CreateNode(XmlNodeType.Element, "rank", "");
                XmlAttribute rankTValue = xml.CreateAttribute("value");
                rankT.Attributes.Append(rankTValue);
                rankTValue.Value = patient.telecom.rank.ToString();
                telecom.AppendChild(rankT);

                #region Create PERIOD TAG

                XmlNode periodT = xml.CreateNode(XmlNodeType.Element, "period", "");
                telecom.AppendChild(periodT);

                #region Create PERIOD childs TAG

                XmlNode startT = xml.CreateNode(XmlNodeType.Element, "start", "");
                XmlAttribute startTValue = xml.CreateAttribute("value");
                startT.Attributes.Append(startTValue);
                startTValue.Value = patient.telecom.period.Start.ToString();
                periodT.AppendChild(startT);

                XmlNode endT = xml.CreateNode(XmlNodeType.Element, "end", "");
                XmlAttribute endTValue = xml.CreateAttribute("value");
                endT.Attributes.Append(endTValue);
                endTValue.Value = patient.telecom.period.End.ToString();
                periodT.AppendChild(endT);

                #endregion

                #endregion

                #endregion

                #endregion

                #region Create GENDER TAG 

                XmlNode gender = xml.CreateNode(XmlNodeType.Element, "gender", "");
                XmlAttribute genderValue = xml.CreateAttribute("value");
                genderValue.Value = patient.gender;
                gender.Attributes.Append(genderValue);
                root.AppendChild(gender);

                #endregion

                #region Create BIRTHDATE TAG

                XmlNode birthDate = xml.CreateNode(XmlNodeType.Element, "birthDate", "");
                XmlAttribute birthDateValue = xml.CreateAttribute("value");
                birthDateValue.Value = patient.birthdate.ToString();
                birthDate.Attributes.Append(birthDateValue);
                root.AppendChild(birthDate);

                #endregion

                #region Create DECEASED TAG

                XmlNode deceased = xml.CreateNode(XmlNodeType.Element, "deceased", "");
                XmlAttribute deceasedValue = xml.CreateAttribute("value");
                deceasedValue.Value = patient.deceased;
                deceased.Attributes.Append(deceasedValue);
                root.AppendChild(deceased);

                #endregion

                #region Create ADDRESS TAG

                XmlNode address = xml.CreateNode(XmlNodeType.Element, "address", "");
                root.AppendChild(address);

                #region Create ADDRESS childs TAG

                XmlNode useA = xml.CreateNode(XmlNodeType.Element, "use", "");
                XmlAttribute useAValue = xml.CreateAttribute("value");
                useA.Attributes.Append(useAValue);
                useAValue.Value = patient.address.Use;
                address.AppendChild(useA);

                XmlNode typeA = xml.CreateNode(XmlNodeType.Element, "type", "");
                XmlAttribute typeAValue = xml.CreateAttribute("value");
                typeA.Attributes.Append(typeAValue);
                typeAValue.Value = patient.address.Type;
                address.AppendChild(typeA);

                XmlNode textA = xml.CreateNode(XmlNodeType.Element, "text", "");
                XmlAttribute textAValue = xml.CreateAttribute("value");
                textA.Attributes.Append(textAValue);
                textAValue.Value = patient.address.Text;
                address.AppendChild(textA);

                XmlNode line = xml.CreateNode(XmlNodeType.Element, "line", "");
                XmlAttribute lineValue = xml.CreateAttribute("value");
                line.Attributes.Append(lineValue);
                lineValue.Value = patient.address.Line;
                address.AppendChild(line);

                XmlNode city = xml.CreateNode(XmlNodeType.Element, "city", "");
                XmlAttribute cityValue = xml.CreateAttribute("value");
                city.Attributes.Append(cityValue);
                cityValue.Value = patient.address.City;
                address.AppendChild(city);

                XmlNode district = xml.CreateNode(XmlNodeType.Element, "district", "");
                XmlAttribute districtValue = xml.CreateAttribute("value");
                district.Attributes.Append(districtValue);
                districtValue.Value = patient.address.District;
                address.AppendChild(district);

                XmlNode state = xml.CreateNode(XmlNodeType.Element, "state", "");
                XmlAttribute stateValue = xml.CreateAttribute("value");
                state.Attributes.Append(stateValue);
                stateValue.Value = patient.address.State;
                address.AppendChild(state);

                XmlNode postalCode = xml.CreateNode(XmlNodeType.Element, "postalCode", "");
                XmlAttribute postalCodeValue = xml.CreateAttribute("value");
                postalCode.Attributes.Append(postalCodeValue);
                postalCodeValue.Value = patient.address.PostalCode;
                address.AppendChild(postalCode);

                XmlNode country = xml.CreateNode(XmlNodeType.Element, "country", "");
                XmlAttribute countryValue = xml.CreateAttribute("value");
                country.Attributes.Append(countryValue);
                countryValue.Value = patient.address.Country;
                address.AppendChild(country);

                #region Create PERIOD TAG

                XmlNode periodA = xml.CreateNode(XmlNodeType.Element, "period", "");
                address.AppendChild(periodA);

                #region Create PERIOD childs TAG

                XmlNode startA = xml.CreateNode(XmlNodeType.Element, "start", "");
                XmlAttribute startAValue = xml.CreateAttribute("value");
                startT.Attributes.Append(startAValue);
                startTValue.Value = patient.address.Period.Start.ToString();
                periodA.AppendChild(startA);

                XmlNode endA = xml.CreateNode(XmlNodeType.Element, "end", "");
                XmlAttribute endAValue = xml.CreateAttribute("value");
                endA.Attributes.Append(endAValue);
                endAValue.Value = patient.address.Period.End.ToString();
                periodA.AppendChild(endA);

                #endregion

                #endregion


                #endregion

                #endregion

                #region Create MARITALSTATUS TAG

                XmlNode marital = xml.CreateNode(XmlNodeType.Element, "maritalStatus", "");
                root.AppendChild(marital);

                #region Create MARITAL(CodeableConcept) childs TAG

                XmlNode codingM = xml.CreateNode(XmlNodeType.Element, "coding", "");
                marital.AppendChild(codingM);

                #region Create Coding(Coding) childs TAG

                XmlNode systemM = xml.CreateNode(XmlNodeType.Element, "system", "");
                XmlAttribute systemMValue = xml.CreateAttribute("value");
                systemM.Attributes.Append(systemMValue);
                systemMValue.Value = patient.martialStatus.coding.system;
                codingM.AppendChild(systemM);

                XmlNode versionM = xml.CreateNode(XmlNodeType.Element, "version", "");
                XmlAttribute versionMValue = xml.CreateAttribute("value");
                versionM.Attributes.Append(versionMValue);
                versionMValue.Value = patient.martialStatus.coding.version;
                codingM.AppendChild(versionM);

                XmlNode codeM = xml.CreateNode(XmlNodeType.Element, "code", "");
                XmlAttribute codeMValue = xml.CreateAttribute("value");
                codeM.Attributes.Append(codeMValue);
                codeMValue.Value = patient.martialStatus.coding.code;
                codingM.AppendChild(codeM);

                XmlNode displayM = xml.CreateNode(XmlNodeType.Element, "display", "");
                XmlAttribute displayMValue = xml.CreateAttribute("value");
                displayM.Attributes.Append(displayMValue);
                displayMValue.Value = patient.martialStatus.coding.display;
                codingM.AppendChild(displayM);

                XmlNode userSelectedM = xml.CreateNode(XmlNodeType.Element, "userSelected", "");
                XmlAttribute userSelectedMValue = xml.CreateAttribute("value");
                userSelectedM.Attributes.Append(userSelectedMValue);
                userSelectedMValue.Value = patient.martialStatus.coding.userSelected.ToString();
                codingM.AppendChild(userSelectedM);

                #endregion

                XmlNode textM = xml.CreateNode(XmlNodeType.Element, "text", "");
                XmlAttribute textMValue = xml.CreateAttribute("value");
                textM.Attributes.Append(textMValue);
                textMValue.Value = patient.martialStatus.text;
                marital.AppendChild(textM);

                #endregion

                #endregion

                #region Create MULTIPLEBIRTH TAG

                XmlNode multipleBirth = xml.CreateNode(XmlNodeType.Element, "multipleBirth", "");
                XmlAttribute multipleBirthValue = xml.CreateAttribute("value");
                multipleBirthValue.Value = patient.multipleBirth.ToString();
                multipleBirth.Attributes.Append(multipleBirthValue);
                root.AppendChild(multipleBirth);

                #endregion

                #region Create PHOTO TAG

                XmlNode photo = xml.CreateNode(XmlNodeType.Element, "photo", "");               
                root.AppendChild(photo);

                XmlNode contentType = xml.CreateNode(XmlNodeType.Element, "contentType", "");
                XmlAttribute contentTypeValue = xml.CreateAttribute("value");
                contentTypeValue.Value = patient.photo.contentType;
                contentType.Attributes.Append(contentTypeValue);
                photo.AppendChild(contentType);

                XmlNode language = xml.CreateNode(XmlNodeType.Element, "language", "");
                XmlAttribute languageValue = xml.CreateAttribute("value");
                languageValue.Value = patient.photo.language;
                language.Attributes.Append(languageValue);
                photo.AppendChild(language);

                XmlNode data = xml.CreateNode(XmlNodeType.Element, "data", "");
                XmlAttribute dataValue = xml.CreateAttribute("value");
                dataValue.Value = new string(patient.photo.data);
                data.Attributes.Append(dataValue);
                photo.AppendChild(data);

                XmlNode url = xml.CreateNode(XmlNodeType.Element, "url", "");
                XmlAttribute urlValue = xml.CreateAttribute("value");
                urlValue.Value = patient.photo.url;
                url.Attributes.Append(urlValue);
                photo.AppendChild(url);

                XmlNode size = xml.CreateNode(XmlNodeType.Element, "size", "");
                XmlAttribute sizeValue = xml.CreateAttribute("value");
                sizeValue.Value = patient.photo.size.ToString();
                size.Attributes.Append(sizeValue);
                photo.AppendChild(size);

                XmlNode hash = xml.CreateNode(XmlNodeType.Element, "hash", "");
                XmlAttribute hashValue = xml.CreateAttribute("value");
                hashValue.Value = new string(patient.photo.hash);
                hash.Attributes.Append(hashValue);
                photo.AppendChild(hash);

                XmlNode title = xml.CreateNode(XmlNodeType.Element, "title", "");
                XmlAttribute titleValue = xml.CreateAttribute("value");
                titleValue.Value = patient.photo.title;
                title.Attributes.Append(titleValue);
                photo.AppendChild(title);

                XmlNode creation = xml.CreateNode(XmlNodeType.Element, "creation", "");
                XmlAttribute creationValue = xml.CreateAttribute("value");
                creationValue.Value = patient.photo.creation.ToString();
                creation.Attributes.Append(creationValue);
                photo.AppendChild(creation);

                #endregion

                #region Create Contact TAG

                XmlNode contact = xml.CreateNode(XmlNodeType.Element, "contact", "");
                root.AppendChild(contact);

                XmlNode relationship = xml.CreateNode(XmlNodeType.Element, "relationship", "");
                contact.AppendChild(relationship);

                #region Create RELATIONSHIP(CodeableConcept) childs TAG

                XmlNode codingR = xml.CreateNode(XmlNodeType.Element, "coding", "");
                relationship.AppendChild(codingR);

                #region Create Coding(Coding) childs TAG

                XmlNode systemR = xml.CreateNode(XmlNodeType.Element, "system", "");
                XmlAttribute systemRValue = xml.CreateAttribute("value");
                systemR.Attributes.Append(systemRValue);
                systemRValue.Value = patient.contact.relationship.coding.system;
                codingR.AppendChild(systemR);

                XmlNode versionR = xml.CreateNode(XmlNodeType.Element, "version", "");
                XmlAttribute versionRValue = xml.CreateAttribute("value");
                versionR.Attributes.Append(versionRValue);
                versionRValue.Value = patient.contact.relationship.coding.version;
                codingR.AppendChild(versionR);

                XmlNode codeR = xml.CreateNode(XmlNodeType.Element, "code", "");
                XmlAttribute codeRValue = xml.CreateAttribute("value");
                codeR.Attributes.Append(codeRValue);
                codeRValue.Value = patient.contact.relationship.coding.code;
                codingR.AppendChild(codeR);

                XmlNode displayR = xml.CreateNode(XmlNodeType.Element, "display", "");
                XmlAttribute displayRValue = xml.CreateAttribute("value");
                displayR.Attributes.Append(displayRValue);
                displayRValue.Value = patient.contact.relationship.coding.display;
                codingR.AppendChild(displayR);

                XmlNode userSelectedR = xml.CreateNode(XmlNodeType.Element, "userSelected", "");
                XmlAttribute userSelectedRValue = xml.CreateAttribute("value");
                userSelectedR.Attributes.Append(userSelectedRValue);
                userSelectedRValue.Value = patient.contact.relationship.coding.userSelected.ToString();
                codingR.AppendChild(userSelectedR);
                #endregion

                XmlNode textR = xml.CreateNode(XmlNodeType.Element, "text", "");
                XmlAttribute textRValue = xml.CreateAttribute("value");
                textR.Attributes.Append(textRValue);
                textRValue.Value = patient.contact.relationship.text;
                relationship.AppendChild(textR);

                #endregion

                #region Create NAME TAG
                XmlNode nameC = xml.CreateNode(XmlNodeType.Element, "name", "");
                contact.AppendChild(nameC);

                #region Create NAME(HUMAN NAME) TAG

                XmlNode useC = xml.CreateNode(XmlNodeType.Element, "use", "");
                XmlAttribute useCValue = xml.CreateAttribute("value");
                useC.Attributes.Append(useCValue);
                useCValue.Value = patient.contact.name.use;
                nameC.AppendChild(useC);

                XmlNode textC = xml.CreateNode(XmlNodeType.Element, "text", "");
                XmlAttribute textCValue = xml.CreateAttribute("value");
                textC.Attributes.Append(textCValue);
                textCValue.Value = patient.contact.name.text;
                nameC.AppendChild(textC);

                XmlNode familyC = xml.CreateNode(XmlNodeType.Element, "family", "");
                XmlAttribute familyCValue = xml.CreateAttribute("value");
                familyC.Attributes.Append(familyCValue);
                familyCValue.Value = patient.contact.name.family;
                nameC.AppendChild(familyC);

                XmlNode givenC = xml.CreateNode(XmlNodeType.Element, "given", "");
                XmlAttribute givenCValue = xml.CreateAttribute("value");
                givenC.Attributes.Append(givenCValue);
                givenCValue.Value = patient.contact.name.given;
                nameC.AppendChild(givenC);

                XmlNode prefixC = xml.CreateNode(XmlNodeType.Element, "prefix", "");
                XmlAttribute prefixCValue = xml.CreateAttribute("value");
                prefixC.Attributes.Append(prefixCValue);
                prefixCValue.Value = patient.contact.name.prefix;
                nameC.AppendChild(prefixC);

                XmlNode suffixC = xml.CreateNode(XmlNodeType.Element, "suffix", "");
                XmlAttribute suffixCValue = xml.CreateAttribute("value");
                suffixC.Attributes.Append(suffixCValue);
                suffixCValue.Value = patient.contact.name.suffix;
                nameC.AppendChild(suffixC);

                #region Create PERIOD TAG
                XmlNode periodC = xml.CreateNode(XmlNodeType.Element, "period", "");
                nameC.AppendChild(periodC);

                #region Create PERIOD childs TAG

                XmlNode startC = xml.CreateNode(XmlNodeType.Element, "start", "");
                XmlAttribute startCValue = xml.CreateAttribute("value");
                startC.Attributes.Append(startCValue);
                startCValue.Value = patient.contact.period.Start.ToString();
                periodC.AppendChild(startC);

                XmlNode endC = xml.CreateNode(XmlNodeType.Element, "end", "");
                XmlAttribute endCalue = xml.CreateAttribute("value");
                endC.Attributes.Append(endCalue);
                endCalue.Value = patient.contact.period.End.ToString();
                periodC.AppendChild(endC);

                #endregion

                #endregion


                #endregion

                #endregion

                #region Create TELECOM TAG

                XmlNode telecomC = xml.CreateNode(XmlNodeType.Element, "telecom", "");
                contact.AppendChild(telecomC);

                #region Create TELECOM(CONTACT POINT) childs TAG

                XmlNode systemC = xml.CreateNode(XmlNodeType.Element, "system", "");
                XmlAttribute systemCValue = xml.CreateAttribute("value");
                systemC.Attributes.Append(systemCValue);
                systemCValue.Value = patient.contact.telecom.system;
                telecomC.AppendChild(systemC);

                XmlNode valueC = xml.CreateNode(XmlNodeType.Element, "value", "");
                XmlAttribute valueCValue = xml.CreateAttribute("value");
                valueC.Attributes.Append(valueCValue);
                valueCValue.Value = patient.contact.telecom.value;
                telecomC.AppendChild(valueC);

                XmlNode useCon = xml.CreateNode(XmlNodeType.Element, "use", "");
                XmlAttribute useConValue = xml.CreateAttribute("value");
                useCon.Attributes.Append(useConValue);
                useConValue.Value = patient.contact.telecom.value;
                telecomC.AppendChild(useCon);

                XmlNode rankC = xml.CreateNode(XmlNodeType.Element, "rank", "");
                XmlAttribute rankCValue = xml.CreateAttribute("value");
                rankC.Attributes.Append(rankCValue);
                rankCValue.Value = patient.contact.telecom.rank.ToString();
                telecomC.AppendChild(rankC);

                #region Create PERIOD TAG

                XmlNode periodCon = xml.CreateNode(XmlNodeType.Element, "period", "");
                telecomC.AppendChild(periodT);

                #region Create PERIOD childs TAG

                XmlNode startCon = xml.CreateNode(XmlNodeType.Element, "start", "");
                XmlAttribute startConValue = xml.CreateAttribute("value");
                startCon.Attributes.Append(startConValue);
                startConValue.Value = patient.contact.telecom.period.Start.ToString();
                periodCon.AppendChild(startCon);

                XmlNode endCon = xml.CreateNode(XmlNodeType.Element, "end", "");
                XmlAttribute endConValue = xml.CreateAttribute("value");
                endCon.Attributes.Append(endConValue);
                endConValue.Value = patient.contact.telecom.period.End.ToString();
                periodCon.AppendChild(endCon);

                #endregion

                #endregion

                #endregion


                #endregion

                #region Create ADDRESS TAG

                XmlNode addressC = xml.CreateNode(XmlNodeType.Element, "address", "");
                contact.AppendChild(addressC);

                #region Create ADDRESS childs TAG

                XmlNode useContact = xml.CreateNode(XmlNodeType.Element, "use", "");
                XmlAttribute useContactValue = xml.CreateAttribute("value");
                useContact.Attributes.Append(useContactValue);
                useContactValue.Value = patient.contact.address.Use;
                addressC.AppendChild(useContact);

                XmlNode typeContact = xml.CreateNode(XmlNodeType.Element, "type", "");
                XmlAttribute typeContactValue = xml.CreateAttribute("value");
                typeContact.Attributes.Append(typeContactValue);
                typeContactValue.Value = patient.contact.address.Type;
                addressC.AppendChild(typeContact);

                XmlNode textContact = xml.CreateNode(XmlNodeType.Element, "text", "");
                XmlAttribute textContactValue = xml.CreateAttribute("value");
                textContact.Attributes.Append(textContactValue);
                textContactValue.Value = patient.contact.address.Text;
                addressC.AppendChild(textContact);

                XmlNode lineContact = xml.CreateNode(XmlNodeType.Element, "line", "");
                XmlAttribute lineContactValue = xml.CreateAttribute("value");
                lineContact.Attributes.Append(lineContactValue);
                lineContactValue.Value = patient.contact.address.Line;
                addressC.AppendChild(lineContact);

                XmlNode cityContact = xml.CreateNode(XmlNodeType.Element, "city", "");
                XmlAttribute cityContactValue = xml.CreateAttribute("value");
                cityContact.Attributes.Append(cityContactValue);
                cityContactValue.Value = patient.contact.address.City;
                addressC.AppendChild(cityContact);

                XmlNode districtContact = xml.CreateNode(XmlNodeType.Element, "district", "");
                XmlAttribute districtContactValue = xml.CreateAttribute("value");
                districtContact.Attributes.Append(districtContactValue);
                districtContactValue.Value = patient.contact.address.District;
                addressC.AppendChild(districtContact);

                XmlNode stateContact = xml.CreateNode(XmlNodeType.Element, "state", "");
                XmlAttribute stateContactValue = xml.CreateAttribute("value");
                stateContact.Attributes.Append(stateContactValue);
                stateContactValue.Value = patient.contact.address.State;
                addressC.AppendChild(stateContact);

                XmlNode postalCodeContact = xml.CreateNode(XmlNodeType.Element, "postalCode", "");
                XmlAttribute postalCodeContactValue = xml.CreateAttribute("value");
                postalCodeContact.Attributes.Append(postalCodeContactValue);
                postalCodeContactValue.Value = patient.contact.address.PostalCode;
                addressC.AppendChild(postalCodeContact);

                XmlNode countryContanct = xml.CreateNode(XmlNodeType.Element, "country", "");
                XmlAttribute countryContanctValue = xml.CreateAttribute("value");
                countryContanct.Attributes.Append(countryContanctValue);
                countryContanctValue.Value = patient.contact.address.Country;
                addressC.AppendChild(countryContanct);

                #region Create PERIOD TAG

                XmlNode periodContact = xml.CreateNode(XmlNodeType.Element, "period", "");
                addressC.AppendChild(periodContact);

                #region Create PERIOD childs TAG

                XmlNode startA = xml.CreateNode(XmlNodeType.Element, "start", "");
                XmlAttribute startAValue = xml.CreateAttribute("value");
                startT.Attributes.Append(startAValue);
                startTValue.Value = patient.address.Period.Start.ToString();
                periodContact.AppendChild(startA);

                XmlNode endA = xml.CreateNode(XmlNodeType.Element, "end", "");
                XmlAttribute endAValue = xml.CreateAttribute("value");
                endA.Attributes.Append(endAValue);
                endAValue.Value = patient.address.Period.End.ToString();
                periodContact.AppendChild(endA);

                #endregion

                #endregion


                #endregion

                #endregion

                #endregion

                xml.Save("Patient_" + patient.identifier.value + ".xml");
                Console.WriteLine("XML scris cu succes!");
            }

            
        }
        static void Main(string[] args)
        {
            Coding coding = new Coding("system", "version", "code", "display", true);
            CodeableConcept codableconcept = new CodeableConcept(coding, "text");
            Period period = new Period(DateTime.Now, DateTime.Now);
            Identifier identifier = new Identifier("use", codableconcept, "system", "value1", period, "assigner");
            Identifier identifier2 = new Identifier("use", codableconcept, "system", "value2", period, "assigner");
            HumanName humanname = new HumanName("use", "text", "family", "given", "prefix", "suffix", period);
            ContactPoint contactpoint = new ContactPoint("system", "value", "use", 2, period);
            Address address = new Address("use", "type", "text", "line", "city", "district", "state", "postalCode", "country", period);
            Attachement attachement = new Attachement("contentType", "language", "daa".ToCharArray(), "url", 2, "da".ToCharArray(), "title", DateTime.Now);
            Contact contact = new Contact(codableconcept, humanname, contactpoint, address, "masculin", "organization", period);
            Communication communication = new Communication(codableconcept, true);
            Link link = new Link("other", "type");
            Patient patient = new Patient(1,identifier, true, humanname, contactpoint, "masculin", DateTime.Now, "viu", address, codableconcept, 2, attachement,contact,communication, "generalPractitioner", "managingOrganization", link );
            Patient patient2 = new Patient(2,identifier2, true, humanname, contactpoint, "feminin", DateTime.Now, "viu", address, codableconcept, 2, attachement, contact, communication, "generalPractitioner", "managingOrganization", link);

            List<Patient> patientsList = new List<Patient>();
            patientsList.Add(patient);
            patientsList.Add(patient2);

            createXml(patientsList);


        }
    }
}
